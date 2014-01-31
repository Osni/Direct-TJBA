﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Direct_TJBA.Models
{
    public class Referencia
    {
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual TipoReferencia TipoReferencia { get; set; }
    }
}