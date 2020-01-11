using System;

namespace HatcheryManagement
{
    class Hatchery
    {
        public void OnRuiBuy(Object source, SaleAmmountArgs e)
        {
            if ((FishTank.rui - e.ammount) >= 0)
            {
                FishTank.rui = FishTank.rui - e.ammount;
                MarketInventory.rui = MarketInventory.rui + e.ammount;
                Console.WriteLine("Rui in Hatchery: " + FishTank.rui);
            }
            else
            {
                Console.WriteLine("Opss! Such ammount of fish is not available.");
            }

        }

        public void OnKatlaBuy(Object source, SaleAmmountArgs e)
        {
            if ((FishTank.katla - e.ammount) >= 0)
            {
                FishTank.katla = FishTank.katla - e.ammount;
                MarketInventory.katla = MarketInventory.katla + e.ammount;
                Console.WriteLine("Katla in Hatchery: " + FishTank.katla);
            }
            else
            {
                Console.WriteLine("Opss! Such ammount of fish is not available.");
            }

        }

        public void OnIlishBuy(Object source, SaleAmmountArgs e)
        {
            if ((FishTank.ilish - e.ammount) >= 0)
            {
                FishTank.ilish = FishTank.ilish - e.ammount;
                MarketInventory.ilish = MarketInventory.ilish + e.ammount;
                Console.WriteLine("Katla in Hatchery: " + FishTank.ilish);
            }
            else
            {
                Console.WriteLine("Opss! Such ammount of fish is not available.");
            }

        }

    }
}