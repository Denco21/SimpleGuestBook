using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

namespace ConsoleUI
{
    internal class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {
            GetGuestInformation();
            PrintGuestInformation();

            Console.ReadLine();
        }


        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }
        private static void GetGuestInformation()
        {
            string moreGuestComing = "";

            do
            {
                GuestModel guest = new GuestModel(); // create a new guest object to store the data its singe guest beacuse we are in the loop and we are going to add it to the list
               
                guest.FirstName = GetInfoFromConsole("Enter your name please:"); 
                guest.LastName = GetInfoFromConsole("Enter your last name please:");
                guest.MessageToHost = GetInfoFromConsole("Enter your message you like to tell  to the host:");
                moreGuestComing = GetInfoFromConsole("Are more guest coming (yes/no): ");

                guest.Date = DateTime.Now;

                guests.Add(guest);

                Console.Clear();
            } while (moreGuestComing.ToLower() == "yes");

        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";
           
            Console.Write(message);
            output = Console.ReadLine();
            return output;
        }
    }
}
