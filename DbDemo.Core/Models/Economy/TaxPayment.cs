using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Economy
{
    public class TaxPayment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaxPaymentId { get; set; }

        [ForeignKey(nameof(Company))] public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
    }
}
