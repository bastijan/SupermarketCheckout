using Xunit;

namespace SupermarketCheckout.Logic.Tests
{
    public class ShoppingCartTests
    {
        [Theory]
        [InlineData("1", 30)]
        [InlineData("2", 50)]
        [InlineData("3", 60)]
        public void ScanTest(string first, int expectedResult)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.ResetShoppingCart();
            var res = cart.Scan(first);

            Assert.NotEqual(0, res);
            Assert.Equal(expectedResult, res);

        }

        [Fact()]
        public void ScanTest_InvalidInput()
        {
            ShoppingCart cart = new ShoppingCart();
            var res = cart.Scan("M");

            Assert.Equal(res, 0);
        }

        [Theory]
        [InlineData(new string[] { "1" }, 30)]
        [InlineData(new string[] { "1", "1" }, 45)]
        [InlineData(new string[] { "1", "1", "1" }, 75)]
        [InlineData(new string[] { "2" }, 50)]
        [InlineData(new string[] { "2", "2" }, 100)]
        [InlineData(new string[] { "2", "2", "2" }, 130)]
        [InlineData(new string[] { "2", "2", "2", "2" }, 180)]
        [InlineData(new string[] { "3" }, 60)]
        [InlineData(new string[] { "3", "3" }, 120)]
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