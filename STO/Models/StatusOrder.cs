using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace STO.Models
{
    public class StatusOrder
    {
        [Key]
        [ScaffoldColumn(false)]
        public int StatusOrderId { get; set; }

        [Required]
        [Display(Name = "Статус")]
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }

        [Required]
        [Display(Name = "Заказ")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        [Required]
        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }      

    }
}