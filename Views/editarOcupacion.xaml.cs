using MVVMOcupaciones.DAL;
using MVVMOcupaciones.Models;
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
    /// Interaction logic for editarOcupacion.xaml
    /// </summary>
    public partial class editarOcupacion : Window
    {
        public editarOcupacion()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DbContexto contexto = new DbContexto();

            Ocupacion ocupacion = new Ocupacion(
                descripcion.Text.ToString(),
                Convert.ToDecimal(ingreso.Text.ToString())
                );
            try
            {
                contexto.Ocupacions.Add(ocupacion);
                if (contexto.SaveChanges() > 0)
                {
                    MessageBox.Show("se guardo");
                    descripcion.Text = "";
                    ingreso.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex.ToString());
            }
            finally
            {
                contexto.Dispose();
            }

           
        }
    }
}
