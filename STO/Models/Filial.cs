using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace STO.Models
{
    public class Filial
    {
        [Key]
        [ScaffoldColumn(false)]
        public int FilialId { get; set; }

        [Required]
        [Display(Name = "Адрес филиала")]
        public string FilialAdress { get; set; }

        public virtual ICollection<Box> Boxes { get; set; }

        public Filial() { this.Boxes = new HashSet<Box>(); }
    }
}