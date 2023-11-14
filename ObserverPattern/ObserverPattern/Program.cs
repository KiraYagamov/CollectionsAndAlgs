namespace ObserverPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TemperatureData data = new TemperatureData();
            
            Clock clock = new Clock();
            Termometr term = new Termometr();
            
            data.RegisterObserver(clock);
            data.RegisterObserver(term);

            data.SetData("20:30", 15.2f);
        }
    }
}