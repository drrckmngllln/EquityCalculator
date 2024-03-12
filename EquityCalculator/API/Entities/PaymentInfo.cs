namespace API.Entities
{
    public class PaymentInfo
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public decimal Interest { get; set; }
        public decimal Insurance { get; set; }
        public decimal Total { get; set; }
    }
}