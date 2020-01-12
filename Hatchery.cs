using System;

namespace HatcheryManagement
{
    class Hatchery
    {
        FishRepo fishRepo = FishRepo.GetInstance();
        MarketStore marketStore = MarketStore.GetInstance();
        public void OnRuiBuy(Object source, SaleAmmountArgs e)
        {
            if ((fishRepo.getRui() - e.ammount) >= 0)
            {
                fishRepo.setRui(fishRepo.getRui() - e.ammount);
                marketStore.setRui(marketStore.getRui() + e.ammount);
                Console.WriteLine("Rui in Hatchery: " + fishRepo.getRui());
            }
            else
            {
                Console.WriteLine("Opss! Such ammount of fish is not available.");
            }

        }

        public void OnKatlaBuy(Object source, SaleAmmountArgs e)
        {
            if ((fishRepo.getKatla() - e.ammount) >= 0)
            {
                fishRepo.setKatla(fishRepo.getKatla() - e.ammount);
                marketStore.setKatla(marketStore.getKatla() + e.ammount);
                Console.WriteLine("Katla in Hatchery: " + fishRepo.getKatla());
            }
            else
            {
                Console.WriteLine("Opss! Such ammount of fish is not available.");
            }

        }

        public void OnIlishBuy(Object source, SaleAmmountArgs e)
        {
            if ((fishRepo.getIlish() - e.ammount) >= 0)
            {
                fishRepo.setIlish(fishRepo.getIlish() - e.ammount);
                marketStore.setIlish(marketStore.getIlish() + e.ammount);
                Console.WriteLine("Ilish in Hatchery: " + fishRepo.getIlish());
            }
            else
            {
                Console.WriteLine("Opss! Such ammount of fish is not available.");
            }

        }

    }
}