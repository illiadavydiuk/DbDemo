using DbDemo.Core.Models.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Housing
{
    public class ResidentHousing
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResidentHousingId { get; set; }

        [ForeignKey(nameof(Resident))] public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }

        [ForeignKey(nameof(Apartment))] public int ApartmentId { get; set; }
        public virtual Apartment Apartment { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
