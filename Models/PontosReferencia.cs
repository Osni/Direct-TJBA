using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Direct_TJBA.Models
{
    public class PontosReferencia
    {
        public virtual int Id { get; set; }
        [Required]
        [Display(Name = "Referência")]
        public virtual Referencia Referencia { get; set; }
        [Required]
        [Display(Name = "Latitude1")]
        public virtual double Latitude { get; set; }
        [Required]
        [Display(Name = "Longitude1")]
        public virtual double Longitude { get; set; }
    }
}