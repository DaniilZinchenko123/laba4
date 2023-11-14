namespace Task3
{
    public class TrafficSimulation
    {
        public void SimulateTraffic(List<Vehicle> vehicles, Road road)
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle Type: {vehicle.Type}");
                Console.WriteLine($"Current Traffic Level: {road.TrafficLevel}");
                vehicle.Move();
                vehicle.Stop();
                Console.WriteLine();
            }
        }
    }
}