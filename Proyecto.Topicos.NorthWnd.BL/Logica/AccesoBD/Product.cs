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

        public IList<Model.Models.Product> BuscarPorProductosDescontinuados()
        {
            IList<Model.Models.Product> resultado;
            using (var _contexto = new Model.Models.NORTHWNDContext())
            {
                //resultado = _contexto.Products.OrderByDescending(c => c.UnitPrice).ToList().Where(c => c.Discontinued.Equals(true)).ToList();
                resultado = _contexto.Products.Where(c => c.Discontinued.Equals(true)).OrderBy(c => c.UnitPrice).ToList();
            }
            return resultado;
        }
    }
}
