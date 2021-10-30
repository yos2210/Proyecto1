using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Topicos.NorthWnd.BL.Logica.AccesoBD
{
    public class Employee
    {
        //private static Model.Models.NORTHWNDContext contexto = new Model.Models.NORTHWNDContext();

        //public IList<Model.Models.Employee> BuscarEmpleadoPorNombreAproxJefatura(String nombreJefatura)
        //{
        //    IList<Model.Models.Employee> resultado;
        //    using (var _contexto = new Model.Models.NORTHWNDContext())
        //    {
        //        resultado = _contexto.Employees.Where(e => e.Title.Contains(nombreJefatura)).OrderBy(e => e.EmployeeId).ToList();
        //    }
        //    return resultado;
        //}

        //public IList<Model.Models.Employee> BuscarEmpleadoPorEdad()
        //{
        //    IList<Model.Models.Employee> resultado;
        //    using (var _contexto = new Model.Models.NORTHWNDContext())
        //    {
        //        resultado = _contexto.Employees.OrderByDescending(e => e.BirthDate).ToList();
        //    }
        //    return resultado;
        //}

        //public IList<Model.Models.Employee> BuscarEmpleadosPorAnnosAntiguedad()
        //{
        //    IList<Model.Models.Employee> resultado;
        //    using (var _contexto = new Model.Models.NORTHWNDContext())
        //    {
        //        resultado = _contexto.Employees.OrderByDescending(e => e.HireDate).ToList();
        //    }
        //    return resultado;
        //}

        //public IList<Model.Models.Employee> BuscarNombreEmpledoEnOrder(String nombreEmpledo)
        //{
        //    IList<Model.Models.Employee> resultado;
        //    using (var _contexto = new Model.Models.NORTHWNDContext())
        //    {
        //        resultado = _contexto.Employees.Include(o => o.Orders).Where(e => e.FirstName.Contains(nombreEmpledo)).Where(e =>e.LastName.Contains(nombreEmpledo)).OrderBy(e => e.EmployeeId).ToList();

        //    }
        //    return resultado;
        //}

    }
}