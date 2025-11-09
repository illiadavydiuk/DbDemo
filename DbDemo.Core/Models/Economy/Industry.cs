using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DbDemo.Core.Models.Economy
{
    public class Industry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IndustryId { get; set; }

        [Required] public string IndustryName { get; set; }

        public virtual ICollection<Company> Companies { get; set; } = new HashSet<Company>();
    }
}
