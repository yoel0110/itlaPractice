namespace classMap.Entities
{
    internal class Student: CommunityMember
    {
        public int SutendSerial { get; set; }
        public string Carreer { get; set; }
        public double Average { get; set; }

        public Student()
        {
            base.Rol = "Student";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"Name: {Name}\n" +
                $"LastName: {LastName}\n" +
                $"Rol: {Rol}\n" +
                $"Salary: {Average}");
        }
    }
}
