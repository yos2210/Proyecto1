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

        [NotMapped]
        public int EdadEmpleado
        {
            get
            {
            DateTime date = DateTime.Now;
            DateTime birthDate = Convert.ToDateTime(this.BirthDate);

            int age = date.Year - birthDate.Year;

            if (date.Month < birthDate.Month || (date.Month == birthDate.Month && date.Day < birthDate.Day))
            {
                age--;
            }
            return age;
            }
            set { }
        }

        [NotMapped]
        public int AnnosAntiguedad
        {
            get
            {
                DateTime date = DateTime.Now;
                DateTime hire = Convert.ToDateTime(this.HireDate);

                int hireYears = date.Year - hire.Year;

                if (date.Month < hire.Month || (date.Month == hire.Month && date.Day < hire.Day))
                {
                    hireYears--;
                }

                return hireYears;
            }
            set { }
        }

    }
}
