using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IList<Model.Models.Product> BuscarProductosPorNombreAproxProveedor(String nombreCompania)
        {
            IList<Model.Models.Product> resultado;
            using (var _contexto = new Model.Models.NORTHWNDContext())
            {
                resultado = _contexto.Products.Where(p => p.Supplier.CompanyName.Contains(nombreCompania)).OrderBy(p => p.SupplierId).ToList();
            }
            return resultado;
        }

        public IList<Model.Models.Product> BuscarProductosPorNombreAproxCategoría(String nombreCategoria)
        {
            IList<Model.Models.Product> resultado;
            using (var _contexto = new Model.Models.NORTHWNDContext())
            {
                resultado = _contexto.Products.Where(p => p.Category.CategoryName.Contains(nombreCategoria)).OrderBy(p => p.CategoryId).ToList();
            }
            return resultado;
        }

    }
}
