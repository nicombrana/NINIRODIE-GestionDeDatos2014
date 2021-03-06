﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public abstract class TipoPublicacion
    {
        public Decimal id { get; set; }
        public String descripcion { get; set; }

        public abstract bool VisibilidadStockParaEditar();


        public abstract String mensajeParaPausada();

        public abstract List<Estado> estadosParaEditarPublicada();
    }
}
