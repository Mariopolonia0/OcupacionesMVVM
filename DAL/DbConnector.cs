using MVVMOcupaciones.Models;
using System.Linq;
using System.Windows;

namespace MVVMOcupaciones.DAL
{
    public class DbConnector
    {
        public OcupacionCollection listarOcupaciones()
        {
            DbContexto contexto = new DbContexto();
            OcupacionCollection lista = new OcupacionCollection();
            foreach (var O in contexto.Ocupacions.ToList())
            {
                lista.Add(O);
            }
                
            return lista;
        }
    }
}
