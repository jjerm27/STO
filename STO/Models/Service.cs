using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace STO.Models
{
    public class Service
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ServiceId { get; set; }

        [Required]
        [Display(Name ="Название услуги")]
        public string ServiceName { get; set; }

        [Required]
        [Display(Name = "Цена за человекочас")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Человекочасы")]
        public double HumanTime { get; set; }

        [Display(Name = "Комментарий")]
        public string Comment { get; set; }


        public virtual ICollection<OrderService> OrderServices { get; set; }

        public Service() { this.OrderServices = new HashSet<OrderService>(); }


    }
}