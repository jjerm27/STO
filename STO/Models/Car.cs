using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace STO.Models
{
    public class Car
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CarId { get; set; }

        [Required]
        [Display(Name ="Гос. номер")]
        public string CarNumber { get; set; }

        [Required]
        [Display(Name = "Марка")]
        public string CarMark { get; set; }

        [Required]
        [Display(Name = "Владелец")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public Car() { this.Orders = new HashSet<Order>(); }
    }
}