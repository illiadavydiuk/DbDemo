using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DbDemo.Core.Models.Common;

namespace DbDemo.Core.Models.Housing
{
    public class ResidentApartment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResidentApartmentId { get; set; }

        [ForeignKey(nameof(Resident))] public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }

        [ForeignKey(nameof(Apartment))] public int ApartmentId { get; set; }
        public virtual Apartment Apartment { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
