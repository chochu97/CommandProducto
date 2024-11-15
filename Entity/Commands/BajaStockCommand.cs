using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Commands
{
    public class BajaStockCommand : Command
    {
        public BajaStockCommand(Producto producto, double cantidad) : base(producto, cantidad)
        {
        }

        public override void Ejecutar()
        {
            produ.RestarStock(_cant);
        }
    }
}
