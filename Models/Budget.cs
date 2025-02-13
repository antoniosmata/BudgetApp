using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class Budget
    {
        public int BudgetID { get; set; }
        public decimal? MonthlyIncome { get; set; }
        public decimal? PlannedExpenses { get; set; }
        public decimal? RemainingBudget { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
