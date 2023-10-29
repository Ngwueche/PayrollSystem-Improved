namespace PayrollSystem.Model
{
    public class Salary : BaseEntity
    {
        public decimal PayDay { get; set; }
        public int RegularHours { get; set; }
        public int OvertimeHours { get; set; }
        public decimal OvertimeRate { get; set; }
        public decimal RegularRate { get; set; }
        public decimal GrossPay { get; set; }
        public decimal NetPay { get; set; }
        public decimal MedicareDeduction { get; set; }
        public decimal RentDeduction { get; set; }
        public decimal FoodDeduction { get; set; }

    }
}
