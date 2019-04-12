using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace STO.Models
{
    public class Order
    {
        [Key]
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        [Required]
        [Display(Name = "Мастер")]
        public string MasterId { get; set; }
        public ApplicationUser Master { get; set; }

        [Required]
        [Display(Name = "Менеджер")]
        public string ManagerId { get; set; }
        public ApplicationUser Manager { get; set; }

        [Required]
        [Display(Name = "Бокс")]
        public int BoxId { get; set; }
        public virtual Box Box { get; set; }

        [Required]
        [Display(Name = "Автомобиль")]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        [Display(Name = "Комментарий")]
        public string Comment { get; set; }

        public virtual ICollection<OrderService> OrderServices { get; set; }
        public virtual ICollection<StatusOrder> StatusOrder { get; set; }
      
        public Order() { this.OrderServices = new HashSet<OrderService>(); this.StatusOrder = new HashSet<StatusOrder>(); }
    }
}