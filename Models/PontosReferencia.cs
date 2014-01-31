using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Direct_TJBA.Models
{
    public class PontosReferencia
    {
        public virtual int Id { get; set; }
        public virtual Referencia Referencia { get; set; }
        public virtual double Latitude { get; set; }
        public virtual double Longitude { get; set; }
    }
}