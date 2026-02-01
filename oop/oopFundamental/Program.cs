

namespace oopFundamental
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Car test = new("Juan", 140, false);

            test.PrintState();
            test.On(); //Turn on the radio
            test.SpeedUp(10);
            test.Off(); //Turn off the radio
            test.PrintState();



            //Bus
            Passenger p1 = new("Juan", "Jimenez");
            Passenger p2 = new("Maria", "Garcia");
            Passenger p3 = new("Yoel", "Lebron");
            Passenger p4 = new("Jose", "Jimenez");
            Passenger p5 = new("Jhon", "Does");
          

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