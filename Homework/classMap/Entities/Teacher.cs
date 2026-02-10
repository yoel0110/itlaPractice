namespace classMap.Entities
{
    internal class Teacher: Employee
    {
        public string Subject { get; set; }

        public Teacher()
        {
            base.Rol = "Teacher";
        }
    }
}
