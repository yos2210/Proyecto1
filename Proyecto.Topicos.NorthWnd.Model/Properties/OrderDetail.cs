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

        [NotMapped]

        public decimal OrderDetailUnitPrice
        {
            get
            {


                decimal unitPrice = this.UnitPrice;
  

                decimal resultado = unitPrice;
                return resultado;

            }
            set { }
        }

        public short OrderDetailQuantity
        {
            get
            {


                short quantity = this.Quantity;


                short resultado = quantity;
                return resultado;

            }
            set { }
        }

        public float OrderDetailDiscount
        {
            get
            {


                float discount = this.Discount;


                float resultado = discount;
                return resultado;

            }
            set { }
        }
        /// <summary>
        /// Obtiene el Monto Bruto
        /// </summary>
        public decimal OrderDetailMontoBruto
        {
            get
            {


                decimal montoBruto = OrderDetailQuantity * OrderDetailUnitPrice;


                decimal resultado = montoBruto;
                return resultado;

            }
            set { }
        }
        /// <summary>
        /// Obtiene el Monto de descuento
        /// </summary>
        public decimal OrderDetailMontoDeDescuento
        {
            get
            {


                decimal montoDescuento = OrderDetailQuantity * OrderDetailUnitPrice* Convert.ToDecimal(OrderDetailDiscount);


                decimal resultado = montoDescuento;
                return resultado;

            }
            set { }
        }
        /// <summary>
        /// Obtiene el Procentaje de Descuento
        /// </summary>
        public float OrderDetailPorcentajeDeDescuento
        {
            get
            {


                float porcentajeDescuento = OrderDetailDiscount * 100;


                float resultado = porcentajeDescuento;
                return resultado;

            }
            set { }
        }

        /// <summary>
        /// Saca el Monto Neto de la Linea
        /// </summary>
        public decimal OrderDetailTotal
        {
            get
            {


                decimal total = OrderDetailQuantity * OrderDetailUnitPrice - OrderDetailMontoDeDescuento;


                decimal resultado = total;
                return resultado;

            }
            set { }
        }
    }
}
