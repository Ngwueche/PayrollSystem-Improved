using PayrollSystem.Model;

namespace PayrollSystem.Logic.Interfaces
{
    public interface IPayrollLogic
    {
        public string AddSalary(Salary salary);
        Salary GetSalary(string id);
        List<Salary> GetSalaries();
        bool DeletePayroll(string Id);
        decimal CalculateGrossPay(int regularHours, int overtimeHours, decimal regularRate, decimal overtimeRate);
        decimal CalculateNetPay(decimal grossPay, decimal deduction);
        decimal CalculateDeduction(decimal grossPay, int percentage);

    }
}
