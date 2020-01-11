using System;
using System.Collections.Generic;

namespace HatcheryManagement
{
    class Hatchery
    {
        public static int rui = 1000, katla = 1000, ilish = 1000;
        public void OnRuiBuy(Object source, SaleAmmountArgs e)
        {
            if ((rui - e.ammount) >= 0)
            {
                rui = rui - e.ammount;
                MarketInventory.rui = MarketInventory.rui + e.ammount;
                Console.WriteLine("Rui in Hatchery: " + rui);
            }
            else
            {
                Console.WriteLine("Opss! Such ammount of fish is not available.");
            }

        }

        public void OnKatlaBuy(Object source, SaleAmmountArgs e)
        {
            if ((katla - e.ammount) >= 0)
            {
                katla = katla - e.ammount;
                MarketInventory.katla = MarketInventory.katla + e.ammount;
                Console.WriteLine("Katla in Hatchery: " + katla);
            }
            else
            {
                Console.WriteLine("Opss! Such ammount of fish is not available.");
            }

        }

        public void OnIlishBuy(Object source, SaleAmmountArgs e)
        {
            if ((ilish - e.ammount) >= 0)
            {
                ilish = ilish - e.ammount;
                MarketInventory.ilish = MarketInventory.ilish + e.ammount;
                Console.WriteLine("Katla in Hatchery: " + ilish);
            }
            else
            {
                Console.WriteLine("Opss! Such ammount of fish is not available.");
            }

        }

    }
}