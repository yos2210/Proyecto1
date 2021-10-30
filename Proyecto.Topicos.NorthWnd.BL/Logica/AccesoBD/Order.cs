using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Topicos.NorthWnd.BL.Logica.AccesoBD
{
   public class Order
    {
        public IList<Model.Models.Order> BuscarNombreEmpledoEnOrder(String nombreEmpledo)
        {
            IList<Model.Models.Order> resultado;
            using (var _contexto = new Model.Models.NORTHWNDContext())
            {
                resultado = _contexto.Orders.Where(o => o.Employee.FirstName.Contains(nombreEmpledo)).Where(o => o.Employee.LastName.Contains(nombreEmpledo)).OrderBy(p => p.EmployeeId).ToList();
            }
            return resultado;
        }

        public IList<Model.Models.Order> BuscarNombreClienteEnOrder(String nombreCliente)
        {
            IList<Model.Models.Order> resultado;
            using (var _contexto = new Model.Models.NORTHWNDContext())
            {
                resultado = _contexto.Orders.Where(o => o.Customer.ContactName.Contains(nombreCliente)).OrderBy(p => p.CustomerId).ToList();
            }
            return resultado;
        }
    }
}
