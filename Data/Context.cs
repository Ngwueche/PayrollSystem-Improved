namespace PayrollSystem.Model.DTO.Data
{
    public class Context
    {
        public IList<Employee> Employees { get; set; }
        public IList<Salary> Salaries { get; set; }
    }
}
