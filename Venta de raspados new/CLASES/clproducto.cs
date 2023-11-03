using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_raspados_new.CLASES
{
    internal class clproducto
    {
        public int PRO_ID { get; set; } // ID ROL, falta cambiarle el tipo de datopor tinyint 
        public string PRO_NOMBRE { get; set; } // NOMBRE
        public string  PRO_PRECIO { get; set; } // PATERNO
        public string PRO_FECHA_ALTA { get; set; } // MATERNO
        public string PRO_DESCRIPCION { get; set; } //LADA
        public string PRO_EXISTENCIA { get; set; } // TELEFONO

    }
}
