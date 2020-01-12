using System;
namespace HatcheryManagement
{
    class MarketInventory
    {
        // public static int rui = 100, katla = 100, ilish = 100;
        MarketStore marketStore = MarketStore.GetInstance();
        public void OnRuiSale(Object source, SaleAmmountArgs e)
        {
            if ((marketStore.getRui() - e.ammount) >= 0)
            {
                marketStore.setRui(marketStore.getRui() - e.ammount);
                System.Console.WriteLine("{0} rui fish SOLD.", e.ammount);
            }
            else
            {
                System.Console.WriteLine("Opss! Such ammount of fish is not available.");
            }
        }
        public void OnKatlaSale(Object source, SaleAmmountArgs e)
        {
            if ((marketStore.getKatla() - e.ammount) >= 0)
            {
                marketStore.setKatla(marketStore.getKatla() - e.ammount);
                System.Console.WriteLine("{0} katla fish SOLD.", e.ammount);
            }
            else
            {
                System.Console.WriteLine("Opss! Such ammount of fish is not available.");
            }
        }
        public void OnIlishSale(Object source, SaleAmmountArgs e)
        {
            if ((marketStore.getIlish() - e.ammount) >= 0)
            {
                marketStore.setIlish(marketStore.getIlish() - e.ammount);
                System.Console.WriteLine("{0} ilish fish SOLD.", e.ammount);
            }
            else
            {
                System.Console.WriteLine("Opss! Such ammount of fish is not available.");
            }
        }
    }
}