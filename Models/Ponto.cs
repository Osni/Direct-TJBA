using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Direct_TJBA.Models
{
    public class Ponto
    {
        public virtual int Id { get; set; }

        [Required(ErrorMessage = "Escolha a Referência")]
        [Display(Name = "Referência")]
        public virtual Referencia Referencia { get; set; }

        [Required(ErrorMessage = "Digite a sequência de Latitudes e Longitudes para o Geoprocessamento")]
        [DisplayFormat(ApplyFormatInEditMode = true, NullDisplayText = "Sem LatLng")]
        [Display(Name = "LatLng")]
        public virtual string LatLng { get; set; }


    }
}