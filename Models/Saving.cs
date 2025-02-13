using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class Saving
    {
        public int SavingsID { get; set; }
        public decimal? EmergencyFund { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
