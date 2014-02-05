using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Direct_TJBA.Models
{
    public class Referencia
    {
        public virtual int Id { get; set; }
        [Required]
        [Display(Name = "Descrição")]
        public virtual string Descricao { get; set; }
        [Required]
        [Display(Name = "Tipo")]
        public virtual TipoReferencia TipoReferencia { get; set; }
    }
}