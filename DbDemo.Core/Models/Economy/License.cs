using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Economy
{
    public class License
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LicenseId { get; set; }

        [Required] public string LicenseType { get; set; }
        public DateTime ExpiryDate { get; set; }

        [ForeignKey(nameof(Company))] public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
