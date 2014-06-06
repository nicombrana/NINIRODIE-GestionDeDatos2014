﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public class Usuario
    {
        public Decimal codigo {get;set;}
        public String id {get; set;}
        public String pass { get; set; }
        public bool habilitado { get; set; }
        public Decimal intentos { get; set; }
        public String tipo { get; set; }
        /*Decimal id_cliente { get; set; }
        Decimal id_empresa { get; set; }
        */

        public Usuario()
        { 
        }

        public Usuario(Decimal cod, String iD, String password, bool habili, Decimal intent,
            String type/*, Decimal idClie, Decimal idEmpr*/)
        {
            codigo = cod;
            id = iD;
            pass = password;
            habilitado = habili;
            intentos = intent;
            tipo = type;/*
            id_cliente = idClie;
            id_empresa = idEmpr;*/
        }
    }
}
