using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public class Orden
    {
        public Cliente Cliente { get; private set; }
        private List<Producto> Productos { get; set; } = new List<Producto>();

        public Orden(Cliente cliente)
        {
            Cliente = cliente;
        }

        public bool AgregarProducto(Producto producto, int cantidad)
        {
            if (producto.ReducirStock(cantidad))
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Productos.Add(producto);
                }
                return true;
            }
            return false;
        }

        public decimal CalcularTotal()
        {
            decimal total = Productos.Sum(p => p.Precio);
            if (Cliente.EsClienteVIP)
            {
                total *= 0.9m; // 10% de descuento para clientes VIP
            }
            return total;
        }

        public int ContarProductos()
        {
            return Productos.Count;
        }
    }
}
