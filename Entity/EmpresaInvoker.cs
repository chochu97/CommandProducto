using Entity.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EmpresaInvoker
    {
        private List<Command> ordenes = new List<Command>();

        public void TomarOrden(Command command)
        {
            ordenes.Add(command);
        }

        public void ProcesarOrden()
        {
            foreach(var orden in ordenes)
            {
                orden.Ejecutar();
                
            }
            ordenes.Clear(); // limpiar la lista desp de usar
        }
    }
}
