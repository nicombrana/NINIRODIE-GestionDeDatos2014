using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Pregunta
    {
        public Decimal pregunta_id { get; set; }
        public Decimal publicacion_id { get; set; }
        public Decimal cliente { get; set; }
        public String descripcion { get; set; }
        public String respuesta { get; set; }
        public DateTime fecha_respuesta { get; set; }

        public Pregunta(Decimal preg,Decimal publi,Decimal client,
              String descrip,String resp,DateTime fecha_resp)
        {
            pregunta_id = preg;
            publicacion_id = publi;
            cliente = client;
            descripcion = descrip;
            respuesta = resp;
            fecha_respuesta = fecha_resp;
        }
    }

}
