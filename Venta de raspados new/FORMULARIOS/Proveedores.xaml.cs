using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Venta_de_raspados_new.CLASES;

namespace Venta_de_raspados_new.FORMULARIOS
{
    /// <summary>
    /// Lógica de interacción para Proveedores.xaml
    /// </summary>
    public partial class Proveedores : Window
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, RoutedEventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            SqlConnection con = new SqlConnection(clconexion.conectar());
            SqlCommand cmd = new SqlCommand(" ", con);

            con.Open();
            cmd.CommandText = "INSERT INTO dbo.PROVEEDOR (PROV_ID, PROV_NOMBRE, PROV_DOMICILIO,PROV_TELEFONO,PROV_CORREO_ELECTRONICO,PROV_LOCALIDAD)" +
                " VALUES(" + Convert.ToInt16(txtid.Text) + ",'" + txtnombre.Text + "','" + txtdomicilio.Text + "','" + txttelefono.Text + "','"
                + txtcorreo.Text + "','" + txtlocalidad + "')";
            //como el id es un entero se le debe agregar el convert y el nombre como es una cadena se ponen comillas dobles 

            cmd.ExecuteNonQuery();
            con.Close();
        }


        private void btneliminar_Click(object sender, RoutedEventArgs e)
        {
            Eliminar();
        }
        private void Eliminar()
        {
            SqlConnection con = new SqlConnection(clconexion.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            bool todobien = false;
            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM dbo.PROVEDORES WHERE PROV_ID=" + Convert.ToInt32(txtid.Text);
                cmd.ExecuteNonQuery();
                todobien = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudieron eliminar los datos. " + e);
            }
            finally
            {
                if (todobien == true)
                {
                    MessageBox.Show("Sus datos se eliminaron correctamente.");
                }
            }
            con.Close();
        }
    }
}

