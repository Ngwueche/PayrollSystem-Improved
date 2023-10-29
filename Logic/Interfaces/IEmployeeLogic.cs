using PayrollSystem.Model;

namespace PayrollSystem.Logic.Interfaces
{
    public interface IEmployeeLogic
    {
        string AddEmployee(Employee employee);
        Employee GetEmployee(string Id);
        List<Employee> GetEmployees();
        bool DeleteEmployee(string Id);
    }
}
