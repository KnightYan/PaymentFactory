namespace PaymentFactory.Payments
{
    public class SalariedPay : IEmployeePay
    {
        public double CalculatePay(Employee e)
        {
            return e.Salary;
        }
    }
}
