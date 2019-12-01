using System.Runtime.Remoting.Messaging;
using NUnit.Framework;

namespace MyDesignPattern.FactoryDesignPattern
{
    [TestFixture]
    public class DepositServiceTest
    {
        [Test]
        public void should_return_xpay_service()
        {
            var depositService = new DepositService();
            var depositRequest = new DepositRequest()
            {
                Amount = 988,
                PaymentMethod = "ThaiQr",
                ServiceProvider = "XPay"
            };
            depositService.Deposit(depositRequest);


        }
    }
}