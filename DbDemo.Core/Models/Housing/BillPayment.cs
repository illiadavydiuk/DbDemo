using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Housing
{
    public class BillPayment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillPaymentId { get; set; }

        [ForeignKey(nameof(UtilityBill))] public int UtilityBillId { get; set; }
        public virtual UtilityBill UtilityBill { get; set; }

        public DateTime PaymentDate { get; set; }
        public decimal AmountPaid { get; set; }
    }
}
