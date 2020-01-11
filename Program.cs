using System;

namespace HatcheryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Your User Type: ");
                Console.WriteLine("Normal User      [Select-1]");
                Console.WriteLine("Admin User       [Select-2]");
                Console.WriteLine("Quit             [Select-0]");
                int userType = Convert.ToInt32(Console.ReadLine());

                if (userType == 1)
                {
                    NormalUser normalUser = new NormalUser();
                    normalUser.task();
                }
                else if(userType == 2)
                {
                    AdminUser adminUser = new AdminUser();
                    adminUser.task();
                }
                else if(userType == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!!");
                }
            }            
        }
    }
}
