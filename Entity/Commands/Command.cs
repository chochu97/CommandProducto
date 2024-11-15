using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Commands
{
    public abstract class Command
    {
        public abstract void Ejecutar();

        protected Producto produ;
        protected double _cant;

        public Command(Producto producto, double cantidad)
        {
            this.produ = producto;
            this._cant = cantidad;
        }
    }
}
