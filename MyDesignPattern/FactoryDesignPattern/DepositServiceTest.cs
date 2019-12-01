using System.Runtime.Remoting.Messaging;
using NUnit.Framework;
using FluentAssertions;


namespace MyDesignPattern.FactoryDesignPattern
{
    [TestFixture]
    public class DepositServiceTest
    {
        [Test]
        public void should_return_xpay_service_do_deposit_string()
        {
            var depositRequest = new DepositRequest()
            {
                Amount = 988,
                PaymentMethod = "ThaiQr",
                ServiceProvider = "XPay"
            };
            var expect= new XPayService().DoDeposit();

            var actual = new DepositService().Deposit(depositRequest);
            
            Assert.AreEqual(expect,actual);
        }

        [Test]
        public void should_return_vicus_service_do_deposit_string()
        {
            var depositRequest = new DepositRequest()
            {
                Amount = 988,
                PaymentMethod = "IB",
                ServiceProvider = "Vicus"
            };
            var expect= new VicusService().DoDeposit();

            var actual = new DepositService().Deposit(depositRequest);
            
            Assert.AreEqual(expect,actual);
        }
    }
}