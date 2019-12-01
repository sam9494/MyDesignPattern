namespace MyDesignPattern.FactoryDesignPattern
{
    public class DepositRequest
    {
        public string ServiceProvider { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }

    }
}