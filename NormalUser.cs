using System;

namespace HatcheryManagement
{
    class NormalUser
    {
        public void task()
        {
            while (true)
            {
                Market market = new Market();
                MarketInventory marketInventory = new MarketInventory();

                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("|            Normal User Mode            |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|    Welcome to Fish Market!!!!!!!!!!!!  |");
                Console.WriteLine("|    want to buy some fish?              |");
                Console.WriteLine("|    For Rui Fish({0})        [Select-1] |", MarketInventory.rui);
                Console.WriteLine("|    For Katla Fish({0})      [Select-2] |", MarketInventory.katla);
                Console.WriteLine("|    For Ilish Fish({0})      [Select-3] |", MarketInventory.ilish);
                Console.WriteLine("|                Quit         [Select-0] |");
                Console.WriteLine(" ----------------------------------------");

                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 0)
                {
                    break;
                }
                else if (option == 1)
                {
                    Console.WriteLine("Rui Selected");
                    Console.WriteLine("Enter the ammount of fish: ");
                    int ammount = Convert.ToInt32(Console.ReadLine());

                    // var mkt = new Market();                      //Publisher
                    // var mktInv = new MarketInventory();          //Subscriber

                    market.saleEvent += marketInventory.OnRuiSale;
                    market.MarketSale(ammount);


                }
                else if (option == 2)
                {
                    Console.WriteLine("Katla Selected");
                    Console.WriteLine("Enter the ammount of fish: ");
                    int ammount = Convert.ToInt32(Console.ReadLine());


                    market.saleEvent += marketInventory.OnKatlaSale;
                    market.MarketSale(ammount);

                }
                else if (option == 3)
                {
                    Console.WriteLine("Ilish Selected");
                    Console.WriteLine("Enter the ammount of fish: ");
                    int ammount = Convert.ToInt32(Console.ReadLine());


                    market.saleEvent += marketInventory.OnIlishSale;
                    market.MarketSale(ammount);
                }
                else
                {
                    System.Console.WriteLine("xxxxxxx   Invalid Input   xxxxxxx");
                }
            }
        }
    }
}