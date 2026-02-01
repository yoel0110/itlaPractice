

namespace oopFundamental
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var corola = new Car();

            corola.PrintState();
            corola.SpeedUp(240);
            corola.PrintState();

            Car test = new("Juan", 140);

            test.PrintState();
            test.SpeedUp(10);
            test.PrintState();

            //Bus
            Passenger p1 = new("Juan", "Jimenez");
            Passenger p2 = new("Maria", "Garcia");
            Passenger p3 = new("Yoel", "Lebron");
            Passenger p4 = new("Jose", "Jimenez");
            Passenger p5 = new("Jhon", "Does");
            Passenger p6 = new("Bill", "Gate");
            Passenger p7 = new("The", "Fruta");
            Passenger p8 = new("Car", "Cox");

            Console.WriteLine("-------------------------------");
            Bus bu2 = new("Expreso Punta Cana", true, 3);
            bu2.GetIn(p1);
            bu2.GetIn(p2);
            bu2.GetIn(p3);


            bu2.Display();

            Console.WriteLine("-------------------------------");
            Bus bu1 = new("Caribe Tour", false, 20);
            bu1.GetIn(p4);
            bu1.GetIn(p5);

            bu1.Display();
        }
    }
}