using PaymentFactory.Payments;
using System;

namespace PaymentFactory
{
    public class PaymentsFactory
    {
        public IEmployeePay MakeEmployeePay(EmployeeType type)
        {
            return type switch
            {
                EmployeeType.Salaried => new SalariedPay(),
                EmployeeType.Hourly => new HourlyPay(),
                EmployeeType.Commissioned => new CommissionedPay(),
                _ => throw new ArgumentException(),
            };
        }
    }
}
