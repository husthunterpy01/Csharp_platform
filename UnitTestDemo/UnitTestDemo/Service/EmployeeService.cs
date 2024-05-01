using UnitTestDemo.Model;

namespace UnitTestDemo.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> _employees;
        // Generate data
        public EmployeeService()
        {
            _employees = new List<Employee>() {
            new Employee()
            {
                Id = 100,
                Name = "John",
                PhoneNo = "123",
                EmailId = "3131@gmai.com"
            },
            new Employee()
            {
                Id = 1000,
                Name = "Mike",
                PhoneNo = "1231313",
                EmailId = "lenovo@gmai.com"
            },
             new Employee()
            {
                Id = 10000,
                Name = "Bruce",
                PhoneNo = "7457634563123",
                EmailId = "bigshell@gmai.com"
            }
            };
        }
        public Employee AddEmployee(Employee employee)
        {
            int newId = _employees.Max(x => x.Id) + 1;
            employee.Id = newId;
            _employees.Add(employee);
            return employee;
        }

        public bool DeleteEmployee(int id)
        {
            var idChecked = _employees.Find(x => x.Id == id);
            if (idChecked != null)
            {
                _employees.Remove(idChecked);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> GetAll()
        {
            return _employees;
        }

        public Employee GetById(int id)
        {
            return _employees.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
