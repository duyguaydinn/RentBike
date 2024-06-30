using System;
using System.Collections.Generic;
using System.Text;

namespace DuyguAydinRentBike
{
    public class StartProgram : BaseProgramOperations
    {
        public virtual void Run()
        {
            base.ShowMessage();
            while (true)
            {
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Bike.GetBikeList();
                        base.ShowMessage();
                        break;

                    case "2":
                        Client.GetClientsList();
                        base.ShowMessage();
                        break;

                    case "3":
                        IRentable rentable = new BikeRent(); // Upcasting
                        if (rentable is BikeRent bikeRent) // Downcasting using is
                        {
                            bikeRent.BikeOptions();
                        }
                        else
                        {
                            Console.WriteLine("Renting operation failed.");
                        }

                        Client client = Client.GetClientById(1);
                        object obj = client;
                        Client castedClient = obj as Client; // Using 'as' operator
                        if (castedClient != null)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Client casting failed.");
                        }

                        base.ShowMessage();
                        break;

                    case "4":
                        return;
                    default:
                        Console.WriteLine("Incorrect selection");
                        break;
                }
            }
        }
    }
    
}
