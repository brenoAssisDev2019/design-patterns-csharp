namespace CompositePattern.Company
{
    public class Manager : IEmployee
    {
        public string Name { get; }
        public string Role { get; }
        public decimal Salary { get; }

        private readonly List<IEmployee> _subordinates = new();

        public Manager(string name, string role, decimal salary)
        {
            Name = name;
            Role = role;
            Salary = salary;
        }

        public void AddSubordinate(IEmployee employee)
        {
            _subordinates.Add(employee);
        }

        public void RemoveSubordinate(IEmployee employee)
        {
            _subordinates.Remove(employee);
        }

        public void DisplayHierarchy(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent * 2)} {Role}: {Name} |  R$ {Salary:N2}");
            foreach (var emp in _subordinates)
            {
                emp.DisplayHierarchy(indent + 1);
            }
        }
    }
}
