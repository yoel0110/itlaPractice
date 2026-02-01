namespace oopFundamental
{
    class Car: Radio
    {
        public string petName = String.Empty;
        public int currSpeed;

        public Car(string petName, int currSpeed, bool turnOn): base(turnOn) 
        {
            this.petName = petName;
            this.currSpeed = currSpeed;
        }


        public void PrintState() => Console.WriteLine($"{petName} Is going {currSpeed} MPH.");
        public bool IsRadioOn { get { return this.turnOn; } }


        public void SpeedUp(int delta) => currSpeed += delta; 
    }
}
