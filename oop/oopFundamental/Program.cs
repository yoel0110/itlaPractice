

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

        }
    }
}