using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Housing
{
    public class UtilityBill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UtilityBillId { get; set; }

        [ForeignKey(nameof(Apartment))] public int ApartmentId { get; set; }
        public virtual Apartment Apartment { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
