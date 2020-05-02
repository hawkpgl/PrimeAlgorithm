using DCSL.RPNFinder;
using Shouldly;
using Xunit;

namespace DCSL.Tests
{
    public class RPNEngineTests
    {
        [Fact]
        public void Should_Return_197()
        {
            // Act
            var rpnEngine = new RPNEngine();
            rpnEngine.LoadRPNPrimes(20);
            var input = rpnEngine.GetRPNByIndex(20);

            // Assert
            input.ShouldBe(197);
        }

        [Fact]
        public void Should_Return_33967()
        {
            // Act
            var rpnEngine = new RPNEngine();
            rpnEngine.LoadRPNPrimes(197);
            var input = rpnEngine.GetRPNByIndex(197);

            // Assert
            input.ShouldBe(33967);
        }

        [Fact]
        public void Should_Return_34673()
        {
            // Act
            var rpnEngine = new RPNEngine();
            rpnEngine.LoadRPNPrimes(200);
            var input = rpnEngine.GetRPNByIndex(200);

            // Assert
            input.ShouldBe(34673);
        }
    }
}
