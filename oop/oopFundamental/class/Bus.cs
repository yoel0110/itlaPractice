namespace oopFundamental
{
    internal class Bus
    {
        private string name = string.Empty;
        private int maxPassenger;
        private bool limited = false;
        private int seatsAvailable;
        
        private List<Passenger> passengers = new List<Passenger>();

        public bool IsLimited { get { return limited; } }

        public Bus(string name, bool limited, int maxPassenger)
        {
            this.name = name;
            this.limited = limited;
            this.maxPassenger = maxPassenger;
        }

        public void Display()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Name: {name}\nCapacity: {seatsAvailable} / {maxPassenger}\nLimited: {limited}");
            Console.WriteLine("-------------------------------");
        }

        public void GetIn(Passenger passenger)
        {
            if (seatsAvailable == maxPassenger)
            {
                Console.WriteLine("Error! this bus is full.");
                return; 
            }

            this.passengers.Add(passenger);
            seatsAvailable++;
        }

        public void GetOut(Passenger passenger)
        {
            if (seatsAvailable == 0) return;
            if (passengers.Contains(passenger))
            {
                foreach(var p in passengers)
                {
                    if(p.Equals(passenger))
                    {
                        passengers.Remove(p);
                        seatsAvailable--;
                    }
                }
            }
            
        }

    }

    
}
