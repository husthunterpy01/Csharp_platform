using UnitTestDemo.Model;

namespace UnitTestDemo.Service
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        Employee AddEmployee(Employee employee);
        bool DeleteEmployee(int id);
    }
}
