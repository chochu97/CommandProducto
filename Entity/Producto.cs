using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    { 
        public string Name { get; set; }
        public double Cantidad { get; set; }

        public void RestarStock(double cant)
        {
            Cantidad = Cantidad - cant;
            Console.WriteLine($"Quitando {cant} unidades de producto {this.Name}");
        }

        public void SumarStock(double cant)
        {
            Cantidad += cant;
            Console.WriteLine($"Agregando {cant} unidades de producto {this.Name}");
        }
    }
}
