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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Decir_Algo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseDown(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has cliqueado el botón!!!");
            hi.Text = " HAS CLICKEADO!!!!";
            hi.FontSize = 32; // TAMAÑO DE LA FUENTE PARA LOS TEXTOS ESCRITOS AQUÍ ANTERIORMENTE!!!!!
                 
        }

        // PARA MODIFICAR COLORES AL TEXTO...

        private void cambiarColor(object sender, MouseEventArgs e)
        {
            hi.Foreground = Brushes.Yellow;
        }

        private void cambiarColorSegundaVez(object sender, MouseEventArgs e)
        {
            hi.Foreground = Brushes.Red;
        }
    }
}
