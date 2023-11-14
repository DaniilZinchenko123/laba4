namespace Task2
{
    public class Program
    {
        static void Main()
        {
            var server = new Server { IPAddress = "192.168.1.1", Power = 1000, OS = "Windows Server", StorageCapacity = 5000, RamSize = 64 };
            var workstation = new Workstation { IPAddress = "192.168.1.2", Power = 500, OS = "Windows 10", GPUModel = "NVIDIA RTX 3080", Monitors = 2 };
            var router = new Router { IPAddress = "192.168.1.3", Power = 200, OS = "RouterOS", Ports = 4, SecurityProtocol = "WPA3" };

            var network = new Network();
            network.AddComputer(server);
            network.AddComputer(workstation);
            network.AddComputer(router);

            network.Connect(server, workstation);
            network.TransmitData(workstation, server, "Hello, Server!");

            network.Disconnect(server, workstation);
        }
    }

}