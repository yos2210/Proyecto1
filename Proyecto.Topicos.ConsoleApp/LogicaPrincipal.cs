using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Topicos.ConsoleApp
{
    public class LogicaPrincipal
    {
        public void BuscarPorProductosDescontinuados()
        {
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Product();
            var resultado = servicio.BuscarPorProductosDescontinuados();
            ImprimirCustomers(resultado);
        }

        private void ImprimirCustomers(IList<NorthWnd.Model.Models.Product> resultado)
        {
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var product in resultado)
            {
                System.Console.WriteLine($"Producto: {product.ProductName} - Descontinuado: {product.Discontinued} - Precio: {product.UnitPrice}");
            }
        }
    }
}
