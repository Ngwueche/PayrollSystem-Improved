namespace PayrollSystem.Model.Deductions
{
    public static class Deductions
    {
        public static Dictionary<string, int> DeductionSchema =
            new Dictionary<string, int>
                {
                    {"Medicare", 2 },
                    {"Rent", 5 },
                    {"Food", 3 }
                };

        //SAME AS ABOVE//
        //public Deductions()
        //{
        //    DeductionSchema = new Dictionary<string, int>();
        //    DeductionSchema.Add("Medicare", 2);
        //    DeductionSchema.Add("Food", 3);
        //    DeductionSchema.Add("Rent", 5);
        //}
    }
}
