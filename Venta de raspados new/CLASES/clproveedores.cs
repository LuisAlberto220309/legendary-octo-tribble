using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_raspados_new.CLASES
{
  
    public class clproveedores
    {
        public int PROV_ID { get; set; } // ID ROL, falta cambiarle el tipo de datopor tinyint 
        public string PROV_NOMBRE { get; set; } // NOMBRE
        public char PROV_TELEFONO { get; set; } // TELEFONO
        public string CP_RAZON { get; set; } // RAZON SOCIAL
        public char CP_TIPO { get; set; } // TIPO: C o P
        public char CP_IDREG { get; set; } // FORANEA ID REGION

        public clproveedores()
        {

        }

    }
    
}

