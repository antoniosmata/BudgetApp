using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public decimal? Rent { get; set; }
        public decimal? WaterBill { get; set; }
        public decimal? NaturalGas { get; set; }
        public decimal? Electricity { get; set; }
        public decimal? Cable { get; set; }
        public decimal? Phone { get; set; }
        public decimal? Gas { get; set; }
        public decimal? Maintenance { get; set; }
        public decimal? Groceries { get; set; }
        public decimal? Restaurants { get; set; }
        public decimal? HealthInsurance { get; set; }
        public decimal? AutoInsurance { get; set; }
        public decimal? OtherExpenses { get; set; }
        public decimal? TotalExpenses { get; set; }
        public DateTime EntryDate { get; set; }
        public decimal? EmergencyFund { get; set; }
    }
}
