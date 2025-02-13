using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class Income
    {
        public int IncomeID { get; set; }
        public decimal? Paycheck1 { get; set; }
        public decimal? Paycheck2 { get; set; }
        public decimal? TotalIncome { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
