using Xunit;
namespace SupermarketCheckout.Logic.Tests
{
    public class ShoppingCartTests
    {
        [Theory]
        [InlineData("1", "Apple")]
        [InlineData("2", "Banana")]
        [InlineData("3", "Peach")]
        public void ScanTest(string first, string expectedResult)
        {
            ShoppingCart cart = new ShoppingCart();
            (string productName, decimal subTotal) res = cart.Scan(first);

            Assert.NotEmpty(res.productName);
            Assert.Matches(expectedResult, res.productName);
        }

        [Fact()]
        public void ScanTest_InvalidInput()
        {
            ShoppingCart cart = new ShoppingCart();
            (string productName, decimal subTotal) res = cart.Scan("M");

            Assert.Null(res.productName);
        }

        [Theory]
        [InlineData(new string[] { "1", "2", "3" }, 140)]
        [InlineData(new string[] { "1", "2", "1", "3" }, 155)]
        [InlineData(new string[] { "1", "2", "1", "1", "3" }, 185)]
        [InlineData(new string[] { "1", "2", "1", "2", "2", "2", "3", "3" }, 345)]

        public void GetTotalTest(string[] products, decimal expectedResult)
        {
            var cart = new ShoppingCart();
            foreach (string product in products)
            {
                cart.Scan(product);
            }

            var total = cart.GetTotal();
            cart.ResetShoppingCart();
            Assert.True(total > 0);
            Assert.Equal(expectedResult, total);
        }
    }
}