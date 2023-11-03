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
using Venta_de_raspados_new.CLASES;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace Venta_de_raspados_new.FORMULARIOS
{
    /// <summary>
    /// Lógica de interacción para Producto.xaml
    /// </summary>
    public partial class Producto : Window
    {
        public Producto()
        {
            InitializeComponent();
            
           
        }

        private void consecutivo() 
        {
            SqlConnection con = new SqlConnection(clconexion.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader dr;
            con.Open();
            cmd.CommandText = "SELECT ISNULL (MAX(PRO_ID),0) + 1 FROM dbo.PRODUCTO";
            cmd.ExecuteReader();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtproid.Text = Convert.ToString(dr.GetInt32(0));
            }
            con.Close();
            dr.Close();
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
            cmd.CommandText = "INSERT INTO PRODUCTO (PRO_ID, ,PRO_PRECIO, PRO_NOMBRE, PRO_EXISTENCIA,PRO_DESCRIPCION)" +
                " VALUES(" + Convert.ToInt16(txtproid.Text) + ",'" + txtproprecio.Text + ",'" + txtpronombre.Text + ",'" + txtexistencias.Text + ",'"
                + txtdescripcion.Text + ")";
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
                cmd.CommandText = "DELETE FROM dbo.PRODUCTO WHERE PRO_ID=" + Convert.ToInt32(txtproid.Text);
                cmd.ExecuteNonQuery();
                todobien = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudieron guardar los datos. " + e);
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

        private void dataproducto_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}

