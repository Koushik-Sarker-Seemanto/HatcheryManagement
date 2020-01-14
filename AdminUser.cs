using System;

namespace HatcheryManagement
{
    class AdminUser
    {
        public void task()
        {
            while(true)
            {
                FishRepo fishRepo = FishRepo.GetInstance();
                MarketStore marketStore = new MarketStore();

                Market market = new Market();
                Hatchery hatchery = new Hatchery();

                Console.WriteLine(" --------------------------------------------");
                Console.WriteLine("|             Admin User Mode                |");
                Console.WriteLine("|                                            |");
                Console.WriteLine("|    want to Add some fish?                  |");
                Console.WriteLine("|    For Rui Fish({0})({1})       [Select-1] |", marketStore.getRui(),fishRepo.getRui());
                Console.WriteLine("|    For Katla Fish({0})({1})     [Select-2] |", marketStore.getKatla(),fishRepo.getKatla());
                Console.WriteLine("|    For Ilish Fish({0})({1})     [Select-3] |", marketStore.getIlish(),fishRepo.getIlish());
                Console.WriteLine("|                Quit             [Select-0] |");
                Console.WriteLine(" --------------------------------------------");

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

                    market.buyEvent += hatchery.OnRuiBuy;
                    market.MarketBuy(ammount);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Katla Selected");

                    Console.WriteLine("Enter the ammount of fish: ");
                    int ammount = Convert.ToInt32(Console.ReadLine());

                    market.buyEvent += hatchery.OnKatlaBuy;
                    market.MarketBuy(ammount);
                }
                else if (option == 3)
                {
                    Console.WriteLine("Ilish Selected");
                    Console.WriteLine("Enter the ammount of fish: ");
                    int ammount = Convert.ToInt32(Console.ReadLine());

                    market.buyEvent += hatchery.OnIlishBuy;
                    market.MarketBuy(ammount);
                }
                else
                {
                    System.Console.WriteLine("xxxxxxx   Invalid Input   xxxxxxx");
                }
            }
        }
    }
}