using PayrollSystem.Logic.Interfaces;
using PayrollSystem.Model;
using PayrollSystem.Model.Deductions;
using PayrollSystem.Model.DTO.Data;

namespace PayrollSystem.Logic
{
    public class PayrollLogic : IPayrollLogic
    {
        private readonly Context _context;
        public PayrollLogic(Context context)
        {
            _context = context;
        }
        public string AddSalary(Salary salary)
        {
            //calculate gross
            salary.GrossPay = CalculateGrossPay(salary.RegularHours,
                                                salary.OvertimeHours,
                                                salary.RegularRate,
                                                salary.OvertimeRate);
            //calclate deductions and then net 
            salary.MedicareDeduction = CalculateDeduction(salary.GrossPay, Deductions.DeductionSchema["Salary"]);
            salary.RentDeduction = CalculateDeduction(salary.GrossPay, Deductions.DeductionSchema["Food"]);
            salary.FoodDeduction = CalculateDeduction(salary.GrossPay, Deductions.DeductionSchema["Rent"]);

            var totalDeduction = salary.MedicareDeduction + salary.RentDeduction + salary.FoodDeduction;
            salary.NetPay = CalculateNetPay(salary.GrossPay, totalDeduction);

            _context.Salaries.Add(salary);
            return $"New deduction added. Id: {salary.Id}";
        }
        public decimal CalculateDeduction(decimal grossPay, int percentage)
        {
            return (percentage / 100) * grossPay;
        }
        public decimal CalculateGrossPay(int regularHours, int overtimeHours, decimal regularRate, decimal overtimeRate)
        {
            decimal regularPay = regularHours * regularHours;
            var overtimePay = 0.0M;
            if (overtimeHours > 0)
            {
                overtimePay = overtimeHours * overtimeRate;
                regularPay += overtimePay;
            }
            return regularPay;
            //return (regularHours * regularRate) + (overtimeHours * overtimeRate);
        }
        public decimal CalculateNetPay(decimal grossPay, decimal totalDeduction)
        {
            return (grossPay - totalDeduction);
        }
        public bool DeletePayroll(string Id)
        {
            var salary = GetSalary(Id);
            if (salary == null)
                return false;
            _context.Salaries.Remove(salary);
            return true;
        }
        public List<Salary> GetSalaries()
        {
            return _context.Salaries.ToList();
        }
        public Salary GetSalary(string id)
        {
            var salary = _context.Salaries.FirstOrDefault(x => x.Id == id);
            return salary ?? null;

            //SAME AS ABOVE
            //if (salary == null)
            //    return null;
            //return salary;

        }
    }
}
