namespace API.Entities
{
    public class EquitySchedule
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public DateTime DueDate { get; set; }
        public int Term { get; set; }
        public List<PaymentInfo> PaymentInfo { get; set; }
    }
}