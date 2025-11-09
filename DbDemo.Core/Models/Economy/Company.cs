using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DbDemo.Core.Models.Common;

namespace DbDemo.Core.Models.Economy
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }

        [Required] public string Name { get; set; }

        [ForeignKey(nameof(Industry))] public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }

        [ForeignKey(nameof(Address))] public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public int NumberOfEmployees { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        public virtual ICollection<License> Licenses { get; set; } = new HashSet<License>();
        public virtual ICollection<TaxPayment> TaxPayments { get; set; } = new HashSet<TaxPayment>();
    }
}
