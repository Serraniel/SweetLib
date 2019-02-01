using System;
using System.Collections.Concurrent;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading;
using SweetLib.Utils.Logger.Message;

namespace SweetLib.Utils.Logger.Memory
{
    public class ArchivableConsoleLogMemory : ILogMemory, IDisposable
    {
        private string TempFile { get; } = Path.GetTempFileName();

        private Timer QueueTimer { get; }

        private ConcurrentQueue<LogMessage> LogQueue { get; } = new ConcurrentQueue<LogMessage>();

        public string ArchiveFile { get; set; }

        public bool AutoProcessQueue { get; set; } = true;

        public bool AutoArchiveOnDispose { get; set; } = true;

        public ArchivableConsoleLogMemory() : this(null) { }

        public ArchivableConsoleLogMemory(string archiveFile)
        {
            ArchiveFile = archiveFile;

            QueueTimer = new Timer(e =>
            {
                if (Monitor.TryEnter(this))
                {
                    try
                    {
                        ProcessQueue();
                    }
                    finally
                    {
                        Monitor.Exit(this);
                    }
                }
            }, null, TimeSpan.Zero, TimeSpan.FromMilliseconds(500));
        }

        ~ArchivableConsoleLogMemory()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void ProcessQueue(bool disposing = false)
        {
            // quick exit
            if (LogQueue.IsEmpty)
                return;

            if (!disposing)
            {
                lock (this)
                {
                    while (!LogQueue.IsEmpty)
                    {
                        if (LogQueue.TryDequeue(out LogMessage message))
                            File.AppendAllText(TempFile, message.ToString() + Environment.NewLine);
                    }
                }
            }
            else
            {
                while (!LogQueue.IsEmpty)
                {
                    if (LogQueue.TryDequeue(out LogMessage message))
                        File.AppendAllText(TempFile, message.ToString() + Environment.NewLine);
                }
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

            if (AutoProcessQueue)
                ProcessQueue();
        }



        public void Forget(LogMessage message)
        {
            var lines = File.ReadAllLines(TempFile).ToList();
            foreach (var line in lines)
            {
                if (line == message.ToString())
                    lines.Remove(line);
            }

            File.WriteAllLines(TempFile, lines);
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

            ProcessQueue(true);

            if (AutoArchiveOnDispose)
            {
                try
                {
                    Archive();
                }
                catch (FileNotFoundException)
                {
                }
            }

            File.Delete(TempFile);
        }
    }
}
