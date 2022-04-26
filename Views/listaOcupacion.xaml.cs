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

namespace MVVMOcupaciones.Views
{
    /// <summary>
    /// Interaction logic for listaOcupacion.xaml
    /// </summary>
    public partial class listaOcupacion : Window
    {
        public listaOcupacion()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            editarOcupacion editarOcupacion = new editarOcupacion();
            editarOcupacion.ShowDialog();
        }
    }
}
