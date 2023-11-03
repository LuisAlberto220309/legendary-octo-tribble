using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using Venta_de_raspados_new.CLASES;

namespace Venta_de_raspados_new.FORMULARIOS
{
    /// <summary>
    /// Lógica de interacción para Usuario.xaml
    /// </summary>
    public partial class Usuario : Window
    {
        public Usuario()
        {
            InitializeComponent();
        }
        private void guardar()
        {
            SqlConnection con = new SqlConnection(clconexion.conectar());
            SqlCommand cmd = new SqlCommand(" ", con);

            con.Open();
            cmd.CommandText = "INSERT INTO CP (USU_ID, USU_NOMBRE, USU_CONTRASEÑA, USU_ROL)" +"VALUES(" + Convert.ToInt16(txtid.Text) + ",'" + txtnombre.Text + ",'" + txtclave.Text + ",'" + cbrol + ",')";
                
            //como el id es un entero se le debe agregar el convert y el nombre como es una cadena se ponen comillas dobles 

            cmd.ExecuteNonQuery();
            con.Close();
        }



        private void eliminar()
        {
            SqlConnection con = new SqlConnection(clconexion.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            bool todobien = false;
            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM USUARIO WHERE USU_ID=" + Convert.ToInt32(txtid.Text);
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

        private void btnguardar_Click(object sender, RoutedEventArgs e)
        {
            guardar();
        }

        private void btneliminar_Click(object sender, RoutedEventArgs e)
        {
            eliminar();
        }
    }
}


       
    

