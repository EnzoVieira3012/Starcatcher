using Xunit;

namespace Starcatcher.Api.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Exemplo de uma asserção simples
            int expected = 5;
            int actual = 5;
            Assert.Equal(expected, actual);
        }
    }
}