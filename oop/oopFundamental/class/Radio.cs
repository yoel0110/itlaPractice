 
namespace oopFundamental
{
    class Radio
    {
        protected bool turnOn;

        public Radio(bool turnOn)
        {
            this.turnOn = turnOn;
        }

        public void On() => turnOn = true; 
            
        public void Off() => turnOn = false;
    }
}
