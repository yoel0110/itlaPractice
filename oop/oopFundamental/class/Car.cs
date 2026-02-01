namespace oopFundamental
{
    class Car
    {
        public string petName = String.Empty;
        public int currSpeed;

        public Car(){}
        public Car(string petName, int currSpeed)
        {
            this.petName = petName;
            this.currSpeed = currSpeed;
        }


        public void PrintState() => Console.WriteLine($"{petName} Is going {currSpeed} MPH.");

        public void SpeedUp(int delta) => currSpeed += delta; 
    }
}
