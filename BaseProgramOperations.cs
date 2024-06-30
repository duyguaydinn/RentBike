using System;
using System.Collections.Generic;
using System.Text;

namespace DuyguAydinRentBike
{
   public abstract class BaseProgramOperations
   {
        public static string[] messageArray = new string[7];
        public virtual void ShowMessage()
        {
            string[] messageArray = 
            { "**** Welcome to Bike Rental ****",
              "---------------------------------------------", 
              "1. Bike List", 
              "2. Customer List", 
              "3. Bike Rental",
              "4. Finish",
              "Select an option: " 
            };

            for (int i = 0; i < messageArray.Length; i++)
            {
                Console.WriteLine(messageArray[i].ToString());
            }
        }
    }
}
