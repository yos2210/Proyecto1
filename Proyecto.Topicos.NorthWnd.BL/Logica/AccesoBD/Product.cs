using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Proyecto.Topicos.NorthWnd.BL.Logica.AccesoBD
{
    public class Product
    {
        private static Model.Models.NORTHWNDContext contexto = new Model.Models.NORTHWNDContext();

        public IList<Model.Models.Product> BuscarProductosDescontinuados()
        {
            IList<Model.Models.Product> resultado;
            using (var _contexto = new Model.Models.NORTHWNDContext())
            {
                resultado = _contexto.Products.Where(p => p.Discontinued.Equals(true)).OrderBy(p => p.UnitPrice).ToList();
            }
            return resultado;
        }

        public IList<Model.Models.Category> BuscarProductosPorNombreAproxCategoría(String nombreCategoria)
        {
            IList<Model.Models.Category> resultado;
            using (var _contexto = new Model.Models.NORTHWNDContext())
            {
                resultado = _contexto.Categories.Include(p => p.Products).Where(p => p.CategoryName.Contains(nombreCategoria)).OrderBy(p => p.CategoryId).ToList();
            }
            return resultado;
        }


        public IList<Model.Models.Product> BuscarPorAproximadoProducto(String producto)
        {
            string strFechaInicial = "1996-01-04 00:00:00.000";
            DateTime fechaInicial = DateTime.Parse(strFechaInicial);
            string strFechaFinal = "1996-12-20 00:00:00.000";
            DateTime fechaFinal = DateTime.Parse(strFechaFinal);

            IList<Model.Models.Product> resultado;
            using (var _contexto = new Model.Models.NORTHWNDContext())
            {
                resultado = _contexto.Products.Include(od => od.OrderDetails.Where(o => o.Order.OrderDate >= fechaInicial && o.Order.OrderDate <= fechaFinal)).Where(p => p.ProductName.Contains(producto)).OrderBy(c => c.ProductId).ToList();
            }
            return resultado;
        }

    }
}
