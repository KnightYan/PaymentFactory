namespace PaymentFactory.Payments
{
    public class CommissionedPay : IEmployeePay
    {
        public double CalculatePay(Employee e)
        {
            return e.Salary + GetCommission(e.Id);
        }

        public double GetCommission(int employeeId)
        {
            return 50;
        }
    }
}
