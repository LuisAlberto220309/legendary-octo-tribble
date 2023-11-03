using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Venta_de_raspados_new.CLASES
{
    internal class clconexion
    {
        public static string conectar()
        {
            string con = @"DATA SOURCE=MAQ1\SQLEXPRESS;INITIAL CATALOG=DBCONTROL_VENTA;USER ID=SA;PASSWORD = 123;";
            //DBCONTROL_VENTA
            return con;
        }
    }
}
