using System;

namespace DuyguAydinRentBike
{
    public class Program
    {
        static void Main(string[] args)
        {
            BikeData.BikeList();
            ClientData.CreateClients();
            StartProgram start = new StartProgram();
            start.Run();
        }
    }
}