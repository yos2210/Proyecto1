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
            //BuscarProductosDescontinuados();
            BuscarProductosPorNombreAproxProveedor();
            BuscarProductosPorNombreAproxCategoría();
            //BuscarEmpleadoPorNombreAproxJefatura();
            BuscarNombreEmpledoEnOrder();
            //BuscarNombreClienteEnOrder();


        }

        /// <summary>
        /// Buscar Productos Descontinuados "Consulta #1"
        /// </summary>
        //private void BuscarProductosDescontinuados()
        //{
        //    var servicio = new NorthWnd.BL.Logica.AccesoBD.Product();
        //    var resultado = servicio.BuscarProductosDescontinuados();
        //    ImprimirProductosDescontinuados(resultado);
        //}

        //private void ImprimirProductosDescontinuados(IList<NorthWnd.Model.Models.Product> resultado)
        //{

        //    System.Console.WriteLine("Consulta 1:\n");
        //    if (resultado == null)
        //    {
        //        System.Console.WriteLine("Lista sin elementos");
        //        return;
        //    }
        //    foreach (var product in resultado)
        //    {
        //        System.Console.WriteLine($"Producto: {product.ProductName} - Descontinuado: {product.Discontinued} - Precio: {product.UnitPrice}");
        //    }
        //}

        /// <summary>
        /// Buscar Productos por Proveedor "Consulta #2"
        /// </summary>

        private void BuscarProductosPorNombreAproxProveedor()
        {
            var compania = "ma";
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Product();
            var resultado = servicio.BuscarProductosPorNombreAproxProveedor(compania);
            ImprimirProductosPorNombreAproxProveedor(resultado);
        }

        private void ImprimirProductosPorNombreAproxProveedor(IList<NorthWnd.Model.Models.Product> resultado)
        {
            System.Console.WriteLine("Consulta 2:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var product in resultado)
            {
                System.Console.WriteLine($"Producto: {product.ProductName} - Provedor: {product.SupplierId}");
            }

            System.Console.WriteLine("\n");
        }

        /// <summary>
        /// Buscar Productos por Categoria "Consulta #3"
        /// </summary>
        private void BuscarProductosPorNombreAproxCategoría()
        {
            var compania = "da";
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Product();
            var resultado = servicio.BuscarProductosPorNombreAproxCategoría(compania);
            ImprimirProductosPorNombreAproxCategoria(resultado);
        }

        private void ImprimirProductosPorNombreAproxCategoria(IList<NorthWnd.Model.Models.Product> resultado)
        {
            System.Console.WriteLine("Consulta 3:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var product in resultado)
            {
                System.Console.WriteLine($"Producto: {product.ProductName} - Categoria: {product.CategoryId}");
            }
            System.Console.WriteLine("\n");
        }



        /// <summary>
        /// Buscar Empleado por Jefatura "Consulta #4"
        /// </summary>
        private void BuscarEmpleadoPorNombreAproxJefatura()
        {
            var jefatura = "repre";
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Employee();
            var resultado = servicio.BuscarEmpleadoPorNombreAproxJefatura(jefatura);
            ImprimirEmpleadosPorNombreAproxJefatura(resultado);
        }


        private void ImprimirEmpleadosPorNombreAproxJefatura(IList<NorthWnd.Model.Models.Employee> resultado)
        {
            System.Console.WriteLine("Consulta 4:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var employee in resultado)
            {
                System.Console.WriteLine($"Empleado: {employee.EmployeeFullName} - Titulo: {employee.Title}");
            }
        }


        /// <summary>
        /// Buscar Empleado por Edad "Consulta #5"
        /// </summary>
        private void BuscarEmpleadoPorEdad()
        {
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Employee();
            var resultado = servicio.BuscarEmpleadoPorEdad();
            ImprimirEmpleadosPorEdad(resultado);
        }


        private void ImprimirEmpleadosPorEdad(IList<NorthWnd.Model.Models.Employee> resultado)
        {
            System.Console.WriteLine("Consulta 5:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var employee in resultado)
            {
                System.Console.WriteLine($"Empleado: {employee.EmployeeFullName} - Edad: {employee.EdadEmpleado}");
            }
        }

        /// <summary>
        /// Buscar Empleado por Edad "Consulta #6"
        /// </summary>
        private void BuscarEmpleadosPorAnnosAntiguedad()
        {
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Employee();
            var resultado = servicio.BuscarEmpleadosPorAnnosAntiguedad();
            ImprimirEmpleadosPorAnnosAntiguedad(resultado);
        }


        private void ImprimirEmpleadosPorAnnosAntiguedad(IList<NorthWnd.Model.Models.Employee> resultado)
        {
            System.Console.WriteLine("Consulta 6:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var employee in resultado)
            {
                System.Console.WriteLine($"Empleado: {employee.EmployeeFullName} - Años de Antiguedad: {employee.AnnosAntiguedad}");
            }
        }

        /// <summary>
        /// Buscar Order por Employee "Consulta #8"
        /// </summary>
        private void BuscarNombreEmpledoEnOrder()
        {
            var jefatura = "s";
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Order();
            var resultado = servicio.BuscarNombreEmpledoEnOrder(jefatura);
            ImprimirEmpleadoEnOrder(resultado);
        }


        private void ImprimirEmpleadoEnOrder(IList<NorthWnd.Model.Models.Order> resultado)
        {
            System.Console.WriteLine("Consulta 8:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var order in resultado)
            {
                System.Console.WriteLine($"Orden: {order.OrderId} - Empleado: {order.Employee.EmployeeFullName}");
            }
        }

        /// <summary>
        /// Buscar Order por Clientes "Consulta #9"
        /// </summary>
        private void BuscarNombreClienteEnOrder()
        {
            var jefatura = "ers";
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Order();
            var resultado = servicio.BuscarNombreClienteEnOrder(jefatura);
            ImprimirClienteEnOrder(resultado);
        }


        private void ImprimirClienteEnOrder(IList<NorthWnd.Model.Models.Order> resultado)
        {
            System.Console.WriteLine("Consulta 9:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var order in resultado)
            {
                System.Console.WriteLine($"Orden: {order.OrderId} - Cliente: {order.CustomerId}");
            }
        }




    }
}
