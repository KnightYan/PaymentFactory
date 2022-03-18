namespace PaymentFactory
{
    public enum EmployeeType
    {
        Commissioned,
        Hourly,
        Salaried
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public EmployeeType Type { get; set; }
    }
}
