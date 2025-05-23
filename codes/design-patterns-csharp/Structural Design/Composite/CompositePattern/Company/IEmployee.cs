namespace CompositePattern.Company
{
    public interface IEmployee
    {
        string Name { get; }
        string Role { get; }
        decimal Salary { get; }

        void DisplayHierarchy(int indent = 0);
    }
}
