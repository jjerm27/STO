using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace STO.Models
{
    public class OrderService
    {
        [Key]
        [ScaffoldColumn(false)]
        public int OrderServiceId { get; set; }

        [Required]
        [Display(Name = "Номер заказа")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }


        [Required]
        [Display(Name = "Тип услуги")]
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

    }
}