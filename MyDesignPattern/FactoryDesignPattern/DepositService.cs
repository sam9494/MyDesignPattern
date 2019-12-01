using System;

namespace MyDesignPattern.FactoryDesignPattern
{
    public class DepositService
    {
        public string Deposit(DepositRequest depositRequest)
        {
            switch (depositRequest.ServiceProvider)
            {
                case "XPay":
                    return new XPayService().DoDeposit();
                case "Vicus":
                    return new VicusService().DoDeposit();
                default:
                    return null;
            }
        }
    }
}