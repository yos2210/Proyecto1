using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Topicos.NorthWnd.BL.Logica.AccesoBD
{
    public class Supplier
    {
        public IList<Model.Models.Supplier> BuscarProductosPorNombreAproxProveedor(String nombreCompania)
        {
            IList<Model.Models.Supplier> resultado;
            using (var _contexto = new Model.Models.NORTHWNDContext())
            {
                resultado = _contexto.Suppliers.Include(p => p.Products).Where(s => s.CompanyName.Contains(nombreCompania)).OrderBy(s => s.SupplierId).ToList();
            }
            return resultado;
        }
    }
}
