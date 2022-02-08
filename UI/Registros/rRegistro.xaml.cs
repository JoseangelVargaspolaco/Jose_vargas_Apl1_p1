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
using Jose_vargas_Apl1_p1.BLL;
using Jose_vargas_Apl1_p1.Entidades;

namespace Jose_vargas_Apl1_p1.UI.Registros
{
    public partial class rRegistro : Window
    {

        public rRegistro()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Productos producto = new Productos(int.Parse(ProductosidTextBox.Text), descripcionTextBox.Text, costoTextBox.Text, ExistenciaTextBox.Text);

            if(!ProductosBLL.Existe(int.Parse(ProductosidTextBox.Text))
            {
                var paso = ProductosBLL.Guardar(producto);
                MessageBox.Show("Producto guardados", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
                
            }else
            {
                MessageBox.Show("ERROR", "Fallo",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void EditarButton_Click(object sender, RoutedEventArgs e)
        {
            Productos producto = new Productos(int.Parse(ProductosidTextBox.Text), descripcionTextBox.Text, costoTextBox.Text, ExistenciaTextBox.Text);

            if(!ProductosBLL.Modificar(int.Parse(ProductosidTextBox.Text))
            {
                var paso = ProductosBLL.Modificar(producto);
                MessageBox.Show("Producto editado", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
                
            }else
            {
                MessageBox.Show("ERROR", "Fallo",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
           Productos producto = new Productos(int.Parse(ProductosidTextBox.Text), descripcionTextBox.Text, costoTextBox.Text, ExistenciaTextBox.Text);

            if(!ProductosBLL.Eliminar(int.Parse(ProductosidTextBox.Text)))
            {
                var paso = ProductosBLL.Eliminar(producto);
                MessageBox.Show("Producto Eliminado", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
                
            }else
            {
                MessageBox.Show("ERROR", "Fallo",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }  
        }
    }
}