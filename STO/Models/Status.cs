using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace STO.Models
{
    public class Status
    {
        [Key]
        [ScaffoldColumn(false)]
        public int StatusId { get; set; }

        [Required]
        [Display(Name = "Название статуса")]
        public string StatusName { get; set; }

        public virtual ICollection<StatusOrder> StatusOrder { get; set; }

        public Status() { this.StatusOrder = new HashSet<StatusOrder>(); }
    }
}