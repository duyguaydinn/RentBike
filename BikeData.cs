namespace DuyguAydinRentBike
{
    internal class BikeData
    {
        public static Bike[] bikeArray = new Bike[6];
        public static void BikeList()
        {
            Bike.PrepareBikeData();
        }
    }
}