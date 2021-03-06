using System;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{

    /// <remarks>
    /// For the tests below to pass, the required permissions must be granted AND Shopify payments must be set as a payment provider in the store's settings
    /// </remarks>
    [Trait("Category", "Shopify payments")]
    public class ShopifyPayments_Tests
    {
        private ShopifyPaymentsService _Service { get; } = new ShopifyPaymentsService(Utils.MyShopifyUrl, Utils.AccessToken);

        [Fact]
        public async Task GetBalance()
        {
            if (await _Service.IsShopifyPaymentAPIEnabled())
            {
                var balances = await _Service.GetBalanceAsync();
                Assert.NotNull(balances);
            }
        }

        [Fact]
        public async Task GetPayouts()
        {
            if (await _Service.IsShopifyPaymentAPIEnabled())
            {
                var payouts = await _Service.ListPayoutsAsync();
                Assert.NotNull(payouts);
            }
        }

        [Fact]
        public async Task GetDisputes()
        {
            if (await _Service.IsShopifyPaymentAPIEnabled())
            {
                var disputes = await _Service.ListDisputesAsync();
                Assert.NotNull(disputes);
            }
        }

        [Fact]
        public async Task GetTransactions()
        {
            if (await _Service.IsShopifyPaymentAPIEnabled())
            {
                var transactions = await _Service.ListTransactionsAsync();
                Assert.NotNull(transactions);
            }
        }
    }
}
