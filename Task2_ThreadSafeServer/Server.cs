using System.Threading;

namespace Task2_ThreadSafeServer
{
    public static class Server
    {
        private static int count;
        private static readonly ReaderWriterLockSlim locker = new ReaderWriterLockSlim();

        public static int GetCount()
        {
            locker.EnterReadLock();
            try
            {
                return count;
            }
            finally
            {
                locker.ExitReadLock();
            }
        }

        public static void AddToCount(int value)
        {
            locker.EnterWriteLock();
            try
            {
                count += value;
            }
            finally
            {
                locker.ExitWriteLock();
            }
        }
    }
}
