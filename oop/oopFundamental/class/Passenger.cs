namespace oopFundamental
{
    class Passenger
    {
        private string name = string.Empty;
        private string lastName = string.Empty;
        private static int id;

        public Passenger(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
            id++;
        }


        public void Update(string? name , string? lastName)
        {
            this.name = string.IsNullOrEmpty(name) ? this.name : name;
            this.lastName = string.IsNullOrEmpty(lastName) ? this.lastName : lastName;
        }

        public void Display()
        {
            Console.WriteLine($"Passeger ID: {Passenger.id} Name: {name}\nLast Name: {lastName}");
        }
    }
}
