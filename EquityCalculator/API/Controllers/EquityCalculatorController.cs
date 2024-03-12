using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class EquityCalculatorController : BaseApiController
    {
        
        [HttpPost("calculator")]
        public async Task<ActionResult<IReadOnlyList<EquitySchedule>>> CalculateEquity(EquityCalculatorDto equityCalculatorDto)
        {
            var equitySchedule = new List<EquitySchedule>();
            decimal balance = equityCalculatorDto.SellingPrice;
            decimal amount = equityCalculatorDto.SellingPrice / equityCalculatorDto.EquityTerm;
            decimal interest = balance * (decimal)0.05;
            decimal insurance = amount * (decimal)0.01;

            for (int i = 0; i <= equityCalculatorDto.EquityTerm - 1; i++)
            {
                decimal GetTotal()
                {
                    return amount + interest + insurance;
                }

                var equity = new EquitySchedule
                {
                    Id = i + 1,
                    Balance = balance - amount,
                    DueDate = equityCalculatorDto.ReservationDate.AddMonths(i + 1),
                    Term = i + 1,
                    PaymentInfo = new List<PaymentInfo>
                    {
                        new PaymentInfo
                        {
                            Id = i + 1,
                            Amount = Convert.ToDecimal(amount),
                            Interest = Convert.ToDecimal(interest),
                            Insurance = insurance,
                            Total = GetTotal()
                        }
                    }
                };
                equitySchedule.Add(equity);
                balance -= amount;
            }
            return equitySchedule;
        }
    }
}