using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Models
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string address;
        private Occupation occupation;

        public Employee() { }

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Address { get => address; set => address = value; }
        public Occupation Occupation { get => occupation; set => occupation = value; }
    }
}
