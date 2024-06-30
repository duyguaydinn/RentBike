using System;
using System.Collections.Generic;
using System.ComponentModel.Design;


namespace DuyguAydinRentBike
{
    public class Client
    {
        public string FullName { get; set; }
        public static Client[] clientArray = new Client[5];

        public static void PrepareClientData()
        {
            var fullName = new string[] { "Duygu Aydin", "Amanda Cows", "Math Mitzal", "Sofia Nats", "Lily  Path" };

            for (int i = 0; i < clientArray.Length; i++)
            {
                clientArray[i] = new Client();
                clientArray[i].FullName = fullName[i];
            }
        }

        public Client()
        {
        }

        public static void GetClientsList() // Show clients list with all informations
        {
            Console.WriteLine("ID | Name and Surname ");
            int i = 1;
            foreach (Client client in clientArray)
            {
                Console.WriteLine($"{i}  | {client.FullName} ");
                i++;
            }
        }
        public static Client GetClientById(int clientId) // Get client from a clients list by index
        {
            if (clientId >= 1 && clientId <= Client.clientArray.Length)
            {
                return Client.clientArray[clientId - 1];
            }
            return null; // Client ID is out of range
        }
        public override string ToString()
        {
            return $"Client FullName: {FullName}";
        }
    }
}