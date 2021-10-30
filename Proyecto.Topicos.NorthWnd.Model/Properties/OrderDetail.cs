using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Topicos.NorthWnd.Model.Models
{
    public partial class OrderDetail
    {
        /*Quantity xUnit price   =Monto bruto 
          Quantity x UnitPrice x (Discount)= Monto de descuento(Double)--->montodescuento
          Discount x 100 =Porcentaje de descuento
          Quantity x UnitPrice - montodescuento =Monto neto de la linea 
         */

        //[NotMapped]
        //public float OrderDetailDiscount
        //{
        //    get
        //    {
        //        float discount = this.Discount;

        //        float resultado = discount;
        //        return resultado;
        //    }
        //    set { }
        //}
        ///// <summary>
        ///// Obtiene el Monto Bruto
        ///// </summary>
        //[NotMapped]
        //public decimal OrderDetailMontoBruto
        //{
        //    get
        //    {
        //        decimal unitPrice = this.UnitPrice;
        //        short quantity = this.Quantity;

        //        decimal montoBruto = unitPrice * quantity;

        //        decimal resultado = montoBruto;
        //        return resultado;
        //    }
        //    set { }
        //}
        ///// <summary>
        ///// Obtiene el Monto de descuento
        ///// </summary>
        //[NotMapped]
        //public decimal OrderDetailMontoDeDescuento
        //{
        //    get
        //    {
        //        decimal montoDescuento = OrderDetailMontoBruto * Convert.ToDecimal(OrderDetailDiscount);

        //        decimal resultado = montoDescuento;
        //        return resultado;
        //    }
        //    set { }
        //}
        ///// <summary>
        ///// Obtiene el Procentaje de Descuento
        ///// </summary>
        //[NotMapped]
        //public string OrderDetailPorcentajeDeDescuento
        //{
        //    get
        //    {
        //        var porcentajeDescuento = OrderDetailDiscount * 100;

        //        var resultado = $"{porcentajeDescuento}%";
        //        return resultado;
        //    }
        //    set { }
        //}

        ///// <summary>
        ///// Saca el Monto Neto de la Linea
        ///// </summary>
        //[NotMapped]
        //public decimal OrderDetailTotal
        //{
        //    get
        //    {
        //        decimal total = OrderDetailMontoBruto - OrderDetailMontoDeDescuento;

        //        decimal resultado = total;
        //        return resultado;
        //    }
        //    set { }
        //}
    }
}
