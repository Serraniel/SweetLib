using System;
using System.Collections.Concurrent;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading;
using SweetLib.Utils.Logger.Message;

namespace SweetLib.Utils.Logger.Memory
{
    public class ArchivableConsoleLogMemory : ILogMemory
    {
        private string TempFile { get; } = Path.GetTempFileName();

        private Timer QueueTimer { get; }

        private ConcurrentQueue<LogMessage> LogQueue { get; } = new ConcurrentQueue<LogMessage>();

        public string ArchiveFile { get; set; } = null;

        public bool AutoArchiveOnDispose { get; set; } = true;

        public ArchivableConsoleLogMemory() : this(null) { }

        public ArchivableConsoleLogMemory(string archiveFile)
        {
            ArchiveFile = archiveFile;

            QueueTimer = new Timer(e => ProcessQueue(), null, TimeSpan.Zero, TimeSpan.FromSeconds(30));
        }

        ~ArchivableConsoleLogMemory()
        {
            Dispose(false);
        }

        private void ProcessQueue()
        {
            if (LogQueue.IsEmpty)
                return;

            lock (this)
            {
                if (LogQueue.IsEmpty)
                    return;

                LogMessage message;
                if (LogQueue.TryDequeue(out message))
                    File.AppendAllText(TempFile, message.ToString());
            }
        }

        public void Remember(LogMessage message)
        {
            var consoleColor = Console.ForegroundColor;

            switch (message.LogLevel)
            {
                case LogLevel.Trace:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case LogLevel.Debug:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case LogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case LogLevel.Warn:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            Console.WriteLine(message.ToString());
            LogQueue.Enqueue(message);

            Console.ForegroundColor = consoleColor;
        }



        public void Forget(LogMessage message)
        {
            lock (this)
            {
                var lines = File.ReadAllLines(TempFile).ToList();
                foreach (var line in lines)
                {
                    if (line == message.ToString())
                        lines.Remove(line);
                }

                File.WriteAllLines(TempFile, lines);
            }
        }

        public void Archive(string fullFileName = null)
        {
            if (fullFileName == null)
                fullFileName = ArchiveFile;

            if (fullFileName == null)
                throw new FileNotFoundException("target file not found");

            using (var tmpFileStream = new FileInfo(TempFile).OpenRead())
            {
                if (!Directory.Exists(Path.GetDirectoryName(fullFileName)))
                    Directory.CreateDirectory(Path.GetDirectoryName(fullFileName));

                using (var compressedFileStream = File.Create(fullFileName))
                {
                    using (var compressionsStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        tmpFileStream.CopyTo(compressionsStream);
                    }
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            QueueTimer.Dispose();

            ProcessQueue();

            if (AutoArchiveOnDispose)
            {
                try
                {
                    Archive();
                }
                catch (FileNotFoundException)
                {
                    if (disposing)
                        throw;
                }
            }

            File.Delete(TempFile);
        }
    }
}
