namespace API.DTOs
{
    public class EquityCalculatorDto
    {
        public decimal SellingPrice { get; set; }
        public DateTime ReservationDate { get; set; }
        public int EquityTerm { get; set; }
    }
}