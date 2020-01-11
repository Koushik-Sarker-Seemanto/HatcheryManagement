using System;

namespace HatcheryManagement
{
    class Market
    {
        public delegate void saleDelegate(Object source, SaleAmmountArgs args);
        public delegate void buyDelegate(Object source, SaleAmmountArgs e);
        public event saleDelegate saleEvent;
        public event buyDelegate buyEvent;

        public void MarketSale(int ammount)
        {
            OnSaleEvent(ammount);
        }
        public void MarketBuy(int ammount)
        {
            OnBuyEvent(ammount);
        }

        protected virtual void OnSaleEvent(int ammount)
        {
            if (saleEvent != null)
            {
                saleEvent(this, new SaleAmmountArgs(){ammount = ammount});
            }
            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }

        protected virtual void OnBuyEvent(int ammount)
        {
            if(buyEvent != null)
            {
                buyEvent(this, new SaleAmmountArgs(){ammount = ammount});
            }
            else{
                Console.WriteLine("Not Subscribed to event");
            }
        }

    }
    public class SaleAmmountArgs: EventArgs
    {
        public int ammount {get; set;}
    }
}