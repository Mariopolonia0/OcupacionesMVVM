using System;
using System.Collections.ObjectModel;

namespace MVVMOcupaciones.Models
{
    public class Ocupacion
    {
        //Registro de Ocupaciones (OcupacionId int,  string , Ingresos float)
        public int OcupacionId { get; set; }
        public string Descripcion { get; set; }
        public Decimal Ingresos { get; set; }
       

        public Ocupacion() {
            this.OcupacionId = 0;
            this.Descripcion = "";
            this.Ingresos = 0;
        }
        public Ocupacion(string descripcion, Decimal ingreso)
        {
            this.OcupacionId = 0;
            this.Descripcion = descripcion;
            this.Ingresos = ingreso;
        }
    }

    public class OcupacionCollection : ObservableCollection<Ocupacion>{}
}
