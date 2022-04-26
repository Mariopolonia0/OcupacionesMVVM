using MVVMOcupaciones.BLL.Commands;
using MVVMOcupaciones.DAL;
using MVVMOcupaciones.Models;
using System;
using System.Windows;
using System.Windows.Input;

namespace MVVMOcupaciones.ViewModels
{
    internal class OcupacionViewModel : IGeneric 
    {
        private OcupacionCollection _listaOcupacion = new OcupacionCollection();
        public string textodescripcion { get; set; } = "";
        public string textoingreso { get; set; } = "";
        public OcupacionCollection ListaOcupacion 
        {
            get
            {
                return _listaOcupacion;
            }
            set
            {
                _listaOcupacion = value;
                if (value != null && value.Count > 0)
                {
                    //CurrentPersona = value[0];
                }
                RaisePropertyChanged("ListaOcupacion");
            }
        }
        private ICommand _ListarOcupacionCommand;
        public ICommand ListarOcupacionCommand
        {
            get
            {
                if (_ListarOcupacionCommand == null)
                    _ListarOcupacionCommand = new RelayCommand(new Action(ListarOcupacion));
                return _ListarOcupacionCommand;
            }
        }

        private ICommand agregarItem;
        public ICommand AgregarOcupacionCommand
        {
            get
            {
                if (agregarItem == null)
                    agregarItem = new RelayCommand(new Action(AgregarOcupacion));
                return agregarItem;
            }
        }
        private void AgregarOcupacion()
        {

            DbContexto contexto = new DbContexto();
            ListaOcupacion.Add(new Ocupacion(textodescripcion, Convert.ToDecimal(textoingreso)));
            Ocupacion ocupacion = new Ocupacion(
               textodescripcion,
               Convert.ToDecimal(textoingreso)
            );
            try
            {
                contexto.Ocupacions.Add(ocupacion);
                if (contexto.SaveChanges() > 0)
                {
                    MessageBox.Show("se guardo");
                    textodescripcion = "";
                    textoingreso = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
            finally
            {
                contexto.Dispose();
            }        
        }

        private void ListarOcupacion()
        {
            ListaOcupacion = App.dbConector.listarOcupaciones();
        }
    }
}
