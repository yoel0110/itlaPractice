namespace classMap.Entities
{
    internal abstract class CommunityMember
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Rol { get; set; }

        public abstract void DisplayInfo();
    }
}
