using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public bool EsClienteVIP { get; set; }

        public Cliente(string nombre, bool esClienteVIP)
        {
            Nombre = nombre;
            EsClienteVIP = esClienteVIP;
        }
    }
}
