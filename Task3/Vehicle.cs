namespace Task3
{
    public class Vehicle : IDriveable
    {
        public double Speed { get; set; }
        public double Size { get; set; }
        public string Type { get; set; }

        public void Move()
        {
            Console.WriteLine($"{Type} is moving at a speed of {Speed} km/h.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Type} has stopped.");
        }
    }
}