namespace CompositePattern.Company
{
    public class Employee : IEmployee
    {
        public string Name { get; }
        public string Role { get; }
        public decimal Salary { get; }

        public Employee(string name, string role, decimal salary)
        {
            Name = name;
            Role = role;
            Salary = salary;
        }

        public void DisplayHierarchy(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent * 2)} {Role}: {Name} |  R$ {Salary:N2}");
        }
    }
}
