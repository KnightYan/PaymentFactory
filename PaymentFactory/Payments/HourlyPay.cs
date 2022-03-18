namespace PaymentFactory.Payments
{
    public class HourlyPay : IEmployeePay
    {
        public double CalculatePay(Employee e)
        {
            return e.Salary * GetHourlysWorkeds(e.Id);
        }

        public double GetHourlysWorkeds(int employeeId)
        {
            return 4;
        }
    }
}
