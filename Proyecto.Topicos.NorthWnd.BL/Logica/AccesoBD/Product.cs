using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Topicos.NorthWnd.BL.Logica.AccesoBD
{
    class Product
    {
        private static Model.Models.NORTHWNDContext contexto = new Model.Models.NORTHWNDContext();
       
        public IList<Model.Models.Product> BuscarPorProductosDescontinuados()
        {
            IList<Model.Models.Product> resultado;
            using (var _contexto = new Model.Models.NORTHWNDContext())
            {
               // resultado = contexto.Products.


            }
            return resultado;
        }
    }
}
