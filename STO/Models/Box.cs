using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace STO.Models
{
    public class Box
    {
        [Key]
        [ScaffoldColumn(false)]
        public int BoxId { get; set; }

        [Required]
        [Display(Name = "Филиал")]
        public int FilialId { get; set; }
        public virtual Filial Filial { get; set; }

        [Required]
        [Display(Name = "Номер бокса")]
        public int BoxNumber { get; set; }
     
        public virtual ICollection<Order> Orders { get; set; }

        public Box() { this.Orders = new HashSet<Order>(); }
    }
}