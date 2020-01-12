using System;

namespace HatcheryManagement
{
    class Hatchery
    {
        FishRepo fishRepo = FishRepo.GetInstance();
        public void OnRuiBuy(Object source, SaleAmmountArgs e)
        {
            if ((fishRepo.rui - e.ammount) >= 0)
            {
                fishRepo.rui = fishRepo.rui - e.ammount;
                MarketInventory.rui = MarketInventory.rui + e.ammount;
                Console.WriteLine("Rui in Hatchery: " + fishRepo.rui);
            }
            else
            {
                Console.WriteLine("Opss! Such ammount of fish is not available.");
            }

        }

        public void OnKatlaBuy(Object source, SaleAmmountArgs e)
        {
            if ((fishRepo.katla - e.ammount) >= 0)
            {
                fishRepo.katla = fishRepo.katla - e.ammount;
                MarketInventory.katla = MarketInventory.katla + e.ammount;
                Console.WriteLine("Katla in Hatchery: " + fishRepo.katla);
            }
            else
            {
                Console.WriteLine("Opss! Such ammount of fish is not available.");
            }

        }

        public void OnIlishBuy(Object source, SaleAmmountArgs e)
        {
            if ((fishRepo.ilish - e.ammount) >= 0)
            {
                fishRepo.ilish = fishRepo.ilish - e.ammount;
                MarketInventory.ilish = MarketInventory.ilish + e.ammount;
                Console.WriteLine("Katla in Hatchery: " + fishRepo.ilish);
            }
            else
            {
                Console.WriteLine("Opss! Such ammount of fish is not available.");
            }

        }

    }
}