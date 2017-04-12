using SweetLib.Utils.Logger.Message;

namespace SweetLib.Utils.Logger.Memory
{
    public interface ILogMemory
    {
        void Remember(LogMessage message);
        void Forget(LogMessage message);
        void Archive(string fullFileName);
    }
}
