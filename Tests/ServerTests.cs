using System.Threading.Tasks;
using Task2_ThreadSafeServer;
using Xunit;

namespace Tests
{
    public class ServerTests
    {
        [Fact]
        public void AddToCount_ShouldBeThreadSafe()
        {
            Parallel.For(0, 1000, _ => Server.AddToCount(1));

            int result = Server.GetCount();
            Assert.Equal(1000, result);
        }
    }
}
