﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Venta_de_raspados_new
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FORMULARIOS.Usuario x = new FORMULARIOS.Usuario();
            x.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            FORMULARIOS.Proveedores x = new FORMULARIOS.Proveedores();
            x.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            FORMULARIOS.Producto x = new FORMULARIOS.Producto();
            x.Show();
        }
    }
}
