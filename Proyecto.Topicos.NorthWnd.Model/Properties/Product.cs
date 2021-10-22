using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Topicos.NorthWnd.Model.Models
{
    public partial class Product
    {
        [NotMapped]

        public string SupplierName
        {
            get
            {
                var getSuplier = this.Supplier.ContactName; 
                
                var resultado = $"{getSuplier}";
                return resultado;

            }
            set { }
        }

        public string CategoryrName
        {
            get
            {
                var getCategory = this.Category.CategoryName;

                var resultado = $"{getCategory}";
                return resultado;

            }
            set { }
        }

        public string ProductStock
        {
            get
            {
                var unitsInStock = this.UnitsInStock + " ";

                var resultado = $"{unitsInStock}";
                return resultado;

            }
            set { }
        }
    }
}
