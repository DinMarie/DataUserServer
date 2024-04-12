// See https://aka.ms/new-console-template for more information
using DataUserServer;
using Model_Users_Data;
using BusinessServiceUser;

namespace UserUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter ID: ");
            string userID = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            string pass = Console.ReadLine();

            Business veri = new Business();
            bool result = veri.Verification(userID, pass);

            if (result)
            {
                Console.WriteLine("Welcome to the Magic Shop");
            }
            else
            {
                Console.WriteLine("Something Wrong");
            }
        }
    }
}

