using PaymentFactory.Payments;
using System;

namespace PaymentFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employeeSalaried = new()
            {
                Id = 1,
                Name = "João Asalariado",
                Salary = 1200,
                Type = EmployeeType.Salaried
            };

            Employee employeeComissioned = new()
            {
                Id = 2,
                Name = "Pedro Comissionado",
                Salary = 900,
                Type = EmployeeType.Commissioned
            };

            Employee employeeHourly = new()
            {
                Id = 3,
                Name = "Junior por Hora",
                Salary = 400,
                Type = EmployeeType.Hourly
            };

            PayEmplyee(employeeSalaried);
            PayEmplyee(employeeComissioned);
            PayEmplyee(employeeHourly);
        }

        private static void PayEmplyee(Employee employee)
        {
            IEmployeePay payer = new PaymentsFactory().MakeEmployeePay(employee.Type);

            var salarity = payer.CalculatePay(employee);

            Console.WriteLine(String.Format("Funcionario: {0}, do Cargo: {1}, Recebeu: {2}", employee.Name, employee.Type, salarity));
        }
    }
}
