﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class CompraInmediata : TipoPublicacion
    {

        public CompraInmediata(Decimal id, String descrip)
        {
            this.id = id;
            this.descripcion = descrip;
        }

        public override bool VisibilidadStockParaEditar()
        {
            return true;
        }

        public override string mensajeParaPausada()
        {
            return "y aumentar el stock";
        }

        public override List<Estado> estadosParaEditarPublicada()
        {
            var estados = new List<Estado>();
            estados.Add(new Pausada(3, "Pausada"));
            estados.Add(new Finalizada(4, "Finalizada"));

            return estados;
        }
    }
}
