
namespace FinancialCrm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Banks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Banks()
        {
            this.BankProcesses = new HashSet<BankProcesses>();
        }
    
        public int BankId { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankTitle { get; set; }
        public Nullable<decimal> BankBalance { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankProcesses> BankProcesses { get; set; }
    }
}
