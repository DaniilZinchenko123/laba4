namespace Task3
{
    public class Program
    {
        static void Main()
        {
            Road road = new Road
            {
                Length = 10.0,
                Width = 2.0,
                NumberOfLanes = 2,
                TrafficLevel = 3
            };

            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Vehicle { Type = "Car", Speed = 60.0, Size = 2.0 },
                new Vehicle { Type = "Truck", Speed = 40.0, Size = 4.0 },
                new Vehicle { Type = "Bus", Speed = 50.0, Size = 3.0 }
            };

            TrafficSimulation simulation = new TrafficSimulation();
            simulation.SimulateTraffic(vehicles, road);
        }
    }
}