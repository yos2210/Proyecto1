using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Topicos.NorthWnd.Model.Models
{
    public partial class Order
    {
        //[NotMapped]
        //public string FechaDuracionPedido
        //{
        //    get
        //    {
        //        DateTime orderDate = Convert.ToDateTime(this.OrderDate);
        //        DateTime shippedDate = Convert.ToDateTime(this.ShippedDate);

        //        TimeSpan difDates = shippedDate - orderDate;

        //        int fechaDuracion = difDates.Days;

        //        var resultado = $"{fechaDuracion}";
        //        return resultado;
        //    }
        //    set { }
        //}

    }
}
