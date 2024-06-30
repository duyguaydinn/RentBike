using System;

namespace DuyguAydinRentBike
{
    internal class BikeRent: BaseRentOperations, IRentable
    {
        protected string priceForClient; 
        protected int selectedByIndex;
        protected int totalCost;
        protected int rentalDuration;
        internal void BikeOptions() // Whole procedure of renting bike
        {
            
            while (true)
            {
                Console.WriteLine("Please enter customer ID: ");
                if (!int.TryParse(Console.ReadLine(), out int selectedClientId)) // if ID is not int
                {
                    Console.WriteLine("Incorrect customer ID format, please enter the number: ");
                    continue; // Ask for input again
                }
                else if (selectedClientId < 1 || selectedClientId > Client.clientArray.Length) // If ID is out of client list index
                {
                    Console.WriteLine("There is no customer with this ID number, please enter a valid ID: ");
                    continue; // Ask for input again
                }

                Client selectedClient = Client.GetClientById(selectedClientId); // Set selected client in variable

                Console.WriteLine($"Welcome, {selectedClient.FullName}");
                Console.WriteLine("Which bike do you want to rent? Enter your bike number: ");
                selectedByIndex = Convert.ToInt32(Console.ReadLine());
                for (int i=0; i< 3; i++)
                {
                    if (selectedByIndex < 1 || selectedByIndex > Bike.bikeArray.Length) // if id is out of bike list index
                    {
                        Console.Write("There is no such bike, please select improvement number: ");
                        selectedByIndex = Convert.ToInt32(Console.ReadLine());
                        i++; // Ask for input again
                    }
                    else if (!Bike.bikeArray[selectedByIndex - 1].available) // if bike is unavailable
                    {
                        Console.Write("The bike is unavailable, please choose another one: ");
                        selectedByIndex = Convert.ToInt32(Console.ReadLine());
                        i++;
                    }
                }
                Bike selectedBike = Bike.GetBikeByIndex(selectedByIndex); // Set selected bike in variable
                priceForClient = CalculateTotal(selectedBike);
                Console.WriteLine($"Price for one day of rental {selectedBike.bikeName} to {priceForClient} Euros");
                Console.WriteLine("For how many days do you want to rent a bike?  ");
                rentalDuration = Convert.ToInt32(Console.ReadLine());
                   
                totalCost = Convert.ToInt32(priceForClient) * rentalDuration;
                Console.WriteLine($"The total rental cost is {totalCost.ToString()}");
                Bike.RentBike(selectedBike);
                break;
            }
        }

        public override string CalculateTotal(Bike selectedBike)
        {
            return (selectedBike.bikePrice).ToString();
        }

        public override string ToString()
        {
            return $"Total Cost: {totalCost}, Price for Client: {priceForClient}, Selected Bike Index: {selectedByIndex}, Rental Duration: {rentalDuration}";
        }

        void IRentable.BikeOptions()
        {
            throw new NotImplementedException();
        }
    }
}
