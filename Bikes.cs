using System;
using System.Collections.Generic;

namespace DuyguAydinRentBike
{
    public class Bike 
    {
        public string bikeName;
        private string bikeColor;
        public int bikePrice;
        public bool available;
        public static Bike[] bikeArray = new Bike[6];
        public static void PrepareBikeData()
        {
            var bikeNames = new string[] { "Q1", "Q2", "Q3", "Q4", "Q5", "Q6" };
            var bikeColors = new string[] { "Red", "Blue", "White", "White", "Orange", "Pink" };
            var bikePrices = new int[] { 10, 11, 12, 10, 13, 15 };

            for (int i = 0; i < bikeNames.Length; i++)
            {
                bikeArray[i] = new Bike();
                bikeArray[i].bikeColor = bikeColors[i];
                bikeArray[i].bikeName = bikeNames[i];
                bikeArray[i].bikePrice = bikePrices[i];
                bikeArray[i].available = true;
            }
        }

        public Bike()
        {

        }

        public void getInformation() // Show information about one bike
        {
            Console.WriteLine($"Bike:\n{this.bikeName}\n{this.bikePrice}");
        }

        public static void GetBikeList() // Show bikes list with all informations
        {
            Console.WriteLine("Bike NAME | Bike Color | Price  |  Available");
            int i = 1;
            foreach (Bike bike in bikeArray)
            {
                string availability = bike.available ? "Available" : "Not Available";
                Console.WriteLine($"{i}|  {bike.bikeName}  |  {bike.bikeColor}  |  {bike.bikePrice}    |  {availability}");
                i++;
            }
        }

        public static void RentBike(Bike oneBike) // Rent a bike by changing availablity status
        {
            if (oneBike.available)
            {
                oneBike.available = false;
                Console.WriteLine($"The bike was rented {oneBike.bikeName}");
            }
            else
            {
                Console.WriteLine("The bike unavailable");
            }
        }
        public static Bike GetBikeByIndex(int index) // Get bike index from list of bikes
        {
            if (index >= 1 && index <= bikeArray.Length)
            {
                return bikeArray[index - 1];
            }
            return null; // Index is out of range
        }
        public override string ToString()
        {
            return $"Bike Name: {bikeName}, Color: {bikeColor}, Price: {bikePrice}, Available: {available}";
        }


    }
}