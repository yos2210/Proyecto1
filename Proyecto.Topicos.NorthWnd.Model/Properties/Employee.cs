using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.Topicos.NorthWnd.Model.Models
{
    public partial class Employee
    {
        [NotMapped]
        public string EmployeeFullName
        {
            get
            {
                var titleOfCortesy = string.Empty;
                if (this.TitleOfCourtesy != null)
                {
                    titleOfCortesy = this.TitleOfCourtesy + " ";
                }

                var firstName = this.FirstName + " ";
                var lastName = this.LastName + " ";

                var resultado = $"{titleOfCortesy}{firstName}{lastName}";
                return resultado;
            }
            set { }
        }


    }
}
