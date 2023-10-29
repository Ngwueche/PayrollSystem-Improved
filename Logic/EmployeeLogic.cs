
using PayrollSystem.Logic.Interfaces;
using PayrollSystem.Model;
using PayrollSystem.Model.DTO.Data;

namespace PayrollSystem.Logic
{
    public class EmployeeLogic : IEmployeeLogic
    {
        private readonly Context _context;
        public EmployeeLogic(Context context)
        {
            _context = context;
        }
        public string AddEmployee(Employee employee)
        {
            //var employeeId = _context.Employees.FirstOrDefault(x => x.Id == Id);
            _context.Employees.Add(employee);
            return $"New employee added. Id: {employee.Id}";
        }

        public bool DeleteEmployee(string Id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == Id);
            if (employee == null)
                return false;
            _context.Employees.Remove(employee);
            return true;
        }

        public Employee GetEmployee(string Id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == Id);
            if (employee == null)
                return null;
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
