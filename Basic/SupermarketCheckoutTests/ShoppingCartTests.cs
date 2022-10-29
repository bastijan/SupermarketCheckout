using Xunit;
namespace SupermarketCheckout.Logic.Tests
{
    public class ShoppingCartTests
    {
        [Theory]
        [InlineData("1", "Apple")]
        [InlineData("2", "Banana")]
        [InlineData("M", null)]
        public void ScanTest(string first, string expectedResult)
        {
            ShoppingCart cart = new ShoppingCart();
            string res = cart.Scan(first);

            Assert.NotEmpty(res);
            Assert.Matches(expectedResult, res);
        }

        [Fact()]
        public void GetTotalTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShowTotalTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

    }
}