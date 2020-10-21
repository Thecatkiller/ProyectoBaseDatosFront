using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDatosFront.http.client.response
{
    public class Trabajador
    {
        public long codigo { get; set; }
        public TipoDocumento tipoDocumento { get; set; }

        public string numeroDocumento { get; set; }
    }
}
