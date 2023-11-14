using System;
using System.Collections.Generic;

namespace Task2
{

    public class Network
    {
        private List<Computer> computers = new List<Computer>();

        public void AddComputer(Computer computer)
        {
            computers.Add(computer);
        }

        public void RemoveComputer(Computer computer)
        {
            computers.Remove(computer);
        }

        public void Connect(Computer source, Computer destination)
        {
            Console.WriteLine($"Connected: {source.IPAddress} -> {destination.IPAddress}");
        }

        public void Disconnect(Computer source, Computer destination)
        {
            Console.WriteLine($"Disconnected: {source.IPAddress} -> {destination.IPAddress}");
        }

        public void TransmitData(Computer source, Computer destination, string data)
        {
            Console.WriteLine($"Data transmitted from {source.IPAddress} to {destination.IPAddress}: {data}");
        }
    }

}