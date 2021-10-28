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
                var suplier = string.Empty;
                if (this.Supplier.CompanyName != null)
                {
                    suplier = this.Supplier.CompanyName ;
                }
                return suplier;
            }
            set { }
        }

        public string CategoryrName
        {
            get
            {
                var category = string.Empty;
                if (this.Category.CategoryName != null)
                {
                    category = this.Category.CategoryName;
                }
                return category;
            }
            set { }
        }

        public short ProductStock
        {
            get
            {
                short unitsInStock = 0;
                if (this.UnitsInStock != null)
                {
                    unitsInStock = (short)this.UnitsInStock;
                }
                return unitsInStock;
            }
            set { }
        }

    }
}
