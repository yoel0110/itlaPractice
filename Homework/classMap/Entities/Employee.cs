namespace classMap.Entities
{
    internal class Employee: CommunityMember
    {
        public decimal Salary { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"Name: {Name}\n" +
                $"LastName: {LastName}\n" +
                $"Rol: {Rol}\n" +
                $"Salary: {Salary}");
        }
    }
}
