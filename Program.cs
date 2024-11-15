using Entity;
using Entity.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandProducto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var empresa = new EmpresaInvoker();

            var producto = new Producto();
            producto.Name = "Raw Cheesecake";
            producto.Cantidad = 20;

            var orden1 = new BajaStockCommand(producto, 2);
            var orden2 = new BajaStockCommand(producto, 5);

            empresa.TomarOrden(orden1); empresa.TomarOrden(orden2);

            empresa.ProcesarOrden();
            Console.ReadKey();
            Console.WriteLine($"\nStock disponible: {producto.Cantidad}");
            Console.ReadKey();

            var orden3 = new AltaStockCommand(producto, 50);
            empresa.TomarOrden(orden3);
            empresa.ProcesarOrden();
            Console.ReadKey();
            Console.WriteLine($"\nStock disponible: {producto.Cantidad}");
            Console.ReadKey();
        }
    }
}
