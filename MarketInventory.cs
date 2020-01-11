using System;
namespace HatcheryManagement
{
    class MarketInventory
    {
        public static int rui = 100, katla = 100, ilish = 100;
        public void OnRuiSale(Object source, SaleAmmountArgs e)
        {
            if ((rui - e.ammount) >= 0)
            {
                rui = rui - e.ammount;
                System.Console.WriteLine("{0} rui fish SOLD.", e.ammount);
            }
            else
            {
                System.Console.WriteLine("Opss! Such ammount of fish is not available.");
            }
        }
        public void OnKatlaSale(Object source, SaleAmmountArgs e)
        {
            if ((katla - e.ammount) >= 0)
            {
                katla = katla - e.ammount;
                System.Console.WriteLine("{0} katla fish SOLD.", e.ammount);
            }
            else
            {
                System.Console.WriteLine("Opss! Such ammount of fish is not available.");
            }
        }
        public void OnIlishSale(Object source, SaleAmmountArgs e)
        {
            if ((ilish - e.ammount) >= 0)
            {
                ilish = ilish - e.ammount;
                System.Console.WriteLine("{0} ilish fish SOLD.", e.ammount);
            }
            else
            {
                System.Console.WriteLine("Opss! Such ammount of fish is not available.");
            }
        }
    }
}