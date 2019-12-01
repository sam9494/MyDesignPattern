using System;

namespace MyDesignPattern.FactoryDesignPattern
{
    public class XPayService : IServiceProviderService 
    {
        public string DoDeposit()
        {
            return "Hi This is XPay";
        }
    }
}