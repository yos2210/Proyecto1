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
            BuscarProductosPorNombreAproxProveedor();
            BuscarProductosPorNombreAproxCategoría();
            BuscarEmpleadoPorNombreAproxJefatura();
            BuscarEmpleadoPorEdad();
            BuscarEmpleadosPorAnnosAntiguedad();
            BuscarTerritorioEmpledo();
            BuscarNombreEmpledoEnOrder();
            BuscarNombreClienteEnOrder();
            BuscarPorAproximadoProducto();
            BuscarFacturasEntreMonto();
           
        }

        /// <summary>
        /// Buscar Productos Descontinuados "Consulta #1"
        /// </summary>
        private void BuscarProductosDescontinuados()
        {
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Product();
            var resultado = servicio.BuscarProductosDescontinuados();
            ImprimirProductosDescontinuados(resultado);
        }

        private void ImprimirProductosDescontinuados(IList<NorthWnd.Model.Models.Product> resultado)
        {

            System.Console.WriteLine("Consulta 1:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var product in resultado)
            {
                System.Console.WriteLine($"Producto: {product.ProductName} - Descontinuado: {product.Discontinued} - Precio: {product.UnitPrice}");
            }
            System.Console.WriteLine("\n");
        }

        /// <summary>
        /// Buscar Productos por Proveedor "Consulta #2"
        /// </summary>

        private void BuscarProductosPorNombreAproxProveedor()
        {
            var compania = "ma";
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Supplier();
            var resultado = servicio.BuscarProductosPorNombreAproxProveedor(compania);
            ImprimirProductosPorNombreAproxProveedor(resultado);
        }

        private void ImprimirProductosPorNombreAproxProveedor(IList<NorthWnd.Model.Models.Supplier> resultado)
        {
            System.Console.WriteLine("\nConsulta 2:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var supplier in resultado)
            {
                foreach (var product in supplier.Products)
                {
                    System.Console.WriteLine($"Producto: {product.ProductName} - Provedor: {supplier.CompanyName}");
                }
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
            System.Console.WriteLine("\nConsulta 3:\n");
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
            System.Console.WriteLine("\nConsulta 4:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var employee in resultado)
            {
                System.Console.WriteLine($"Empleado: {employee.EmployeeFullName} - Titulo: {employee.Title}");
            }
            System.Console.WriteLine("\n");
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
            System.Console.WriteLine("\nConsulta 5:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var employee in resultado)
            {
                System.Console.WriteLine($"Empleado: {employee.EmployeeFullName} - Edad: {employee.EdadEmpleado}");
            }
            System.Console.WriteLine("\n");
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
            System.Console.WriteLine("\nConsulta 6:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var employee in resultado)
            {
                System.Console.WriteLine($"Empleado: {employee.EmployeeFullName} - Años de Antiguedad: {employee.AnnosAntiguedad}");
            }
            System.Console.WriteLine("\n");
        }

        /// <summary>
        /// Buscar Employee descripcion de territorio "Consulta #7"
        /// </summary>
        private void BuscarTerritorioEmpledo()
        {
            var territori = "san";
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Employee();
            var resultado = servicio.BuscarTerritorioEmpledo(territori);
            ImprimirTerritorioEmpledo(resultado);
        }


        private void ImprimirTerritorioEmpledo(IList<NorthWnd.Model.Models.Employee> resultado)
        {
            System.Console.WriteLine("\nConsulta 7:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var employee in resultado)
            {
                foreach (var territori in employee.EmployeeTerritories)
                {
                    System.Console.WriteLine($"Empleado: {employee.EmployeeFullName} - Territori: {territori.TerritoryId}");
                }

            }
            System.Console.WriteLine("\n");
        }

        /// <summary>
        /// Buscar Order por Employee "Consulta #8"
        /// </summary>
        private void BuscarNombreEmpledoEnOrder()
        {
            var jefatura = "la";
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Employee();
            var resultado = servicio.BuscarNombreEmpledoEnOrder(jefatura);
            ImprimirEmpleadoEnOrder(resultado);
        }


        private void ImprimirEmpleadoEnOrder(IList<NorthWnd.Model.Models.Employee> resultado)
        {
            System.Console.WriteLine("\nConsulta 8:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var employee in resultado)
            {
                foreach (var order in employee.Orders)
                {
                    System.Console.WriteLine($"Orden: {order.OrderId} - Empleado: {employee.EmployeeFullName}");
                }

            }
            System.Console.WriteLine("\n");
        }

        /// <summary>
        /// Buscar Order por Clientes "Consulta #9"
        /// </summary>
        private void BuscarNombreClienteEnOrder()
        {
            var jefatura = "ers";
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Customer();
            var resultado = servicio.BuscarNombreClienteEnOrder(jefatura);
            ImprimirClienteEnOrder(resultado);
        }


        private void ImprimirClienteEnOrder(IList<NorthWnd.Model.Models.Customer> resultado)
        {
            System.Console.WriteLine("\nConsulta 9:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var customer in resultado)
            {
                foreach (var order in customer.Orders)
                {
                    System.Console.WriteLine($"Orden: {order.OrderId} - Cliente: {customer.ContactName}");
                }
            }
            System.Console.WriteLine("\n");
        }

        /// <summary>
        /// Buscar por nombre aproximado de producto "Consulta #10"
        /// </summary>
        private void BuscarPorAproximadoProducto()
        {
            var producto = "chef";
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Product();
            var resultado = servicio.BuscarPorAproximadoProducto(producto);
            ImprimirPorAproximadoProducto(resultado);
        }


        private void ImprimirPorAproximadoProducto(IList<NorthWnd.Model.Models.Product> resultado)
        {
            System.Console.WriteLine("\nConsulta 10:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var product in resultado)
            {
                foreach (var orderD in product.OrderDetails)
                {
                    System.Console.WriteLine($"Orden: {orderD.OrderId} - Producto: {product.ProductName} - CantidadProductos {orderD.Quantity}");

                }
            }
            System.Console.WriteLine("\n");
        }

        private void BuscarFacturasEntreMonto()
        {
            var servicio = new NorthWnd.BL.Logica.AccesoBD.Order();
            var resultado = servicio.BuscarFacturasEntreMonto();
            ImprimirFacturasEntreMonto(resultado);
        }

        /// <summary>
        /// Buscar por Facturas entre monto "Consulta #11"
        /// </summary>
        private void ImprimirFacturasEntreMonto(IList<NorthWnd.Model.Models.Order> resultado)
        {
            System.Console.WriteLine("\nConsulta 11:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var order in resultado)
            {
                foreach (var orderD in order.OrderDetails)
                {
                    System.Console.WriteLine($"Orden: {orderD.OrderId} - SubTotal: {orderD.OrderDetailMontoBruto.ToString("N3")} - Descuesto: {orderD.OrderDetailMontoDeDescuento.ToString("N3")} - Total: {orderD.OrderDetailTotal.ToString("N3")}");

                }
            }
            System.Console.WriteLine("\n");
        }
    }
}
