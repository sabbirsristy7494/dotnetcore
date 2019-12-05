using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee () {ID = 1, Name="Sabbir", Department="Developer", Email="sabbirsristy@gmail.com"},
                new Employee () {ID = 2, Name="Talha", Department="Lecturer", Email="talhaaziz@gmail.com"},
                new Employee () {ID = 3, Name="Radit", Department="Researcher", Email="ahsanradit@gmail.com"},

            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.ID == Id);
        }
    }
}
