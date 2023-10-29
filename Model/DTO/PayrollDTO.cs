namespace PayrollSystem.Model.DTO
{
    public class PayrollDTO
    {
        public string EmployeeName { get; set; }
        public string ActiveStatus { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string PayDate { get; set; }
        public string RegularHours { get; set; }
        public string OvertimeHours { get; set; }
        public string OvertimeRate { get; set; }
        public string RegularRate { get; set; }
        public string GrossPay { get; set; }
        public string NetPay { get; set; }
        public string Medicare { get; set; }
        public string Food { get; set; }
        public string Rent { get; set; }
    }
}
