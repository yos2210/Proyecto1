using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Topicos.ConsoleApp
{
    public class LogicaPrincipal
    {
        public void GenerarConsultas()
        {
            BuscarProductosDescontinuados();
            BuscarProductosPorNombreAproxCategoría();
        }

        private void BuscarProductosDescontinuados()
        {
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Product();
            var resultado = servicio.BuscarProductosDescontinuados();
            ImprimirProductosDescontinuados(resultado);
        }

        private void ImprimirProductosDescontinuados(IList<NorthWnd.Model.Models.Product> resultado)
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

        private void BuscarProductosPorNombreAproxCategoría()
        {
            var compania = "ma";
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Product();
            var resultado = servicio.BuscarProductosPorNombreAproxCategoría(compania);
            ImprimirProductosPorNombreAproxCategoría(resultado);
        }

        private void ImprimirProductosPorNombreAproxCategoría(IList<NorthWnd.Model.Models.Product> resultado)
        {
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var product in resultado)
            {
                System.Console.WriteLine($"Producto: {product.ProductName} - Provedor: {product.SupplierId}");
            }
        }
    }
}
