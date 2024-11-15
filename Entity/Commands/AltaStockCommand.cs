using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Commands
{
    public class AltaStockCommand : Command
    {
        public AltaStockCommand(Producto producto, double cantidad) : base(producto, cantidad)
        {
        }

        public override void Ejecutar()
        {
            produ.SumarStock(_cant);
        }
    }
}
