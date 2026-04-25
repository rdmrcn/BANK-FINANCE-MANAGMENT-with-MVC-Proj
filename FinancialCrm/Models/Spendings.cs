
namespace FinancialCrm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Spendings
    {
        public int SpendingId { get; set; }
        public string SpendingTitle { get; set; }
        public Nullable<decimal> SpendingAmount { get; set; }
        public Nullable<System.DateTime> SpendingDate { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual Categories Categories { get; set; }
    }
}
