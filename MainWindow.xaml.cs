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
using Jose_vargas_Apl1_p1.UI.Consultas;
using Jose_vargas_Apl1_p1.UI.Registros;

using Jose_vargas_Apl1_p1.UI.Registros;

namespace Jose_vargas_Apl1_p1
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

        private void RegistroMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var rRegistro = new rRegistro();
            rRegistro.Show();
        }


        private void ConsultaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var cConsulta = new cConsulta();
            cConsulta.Show();
        }

    }
}
