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
                // fishRepo.setRui(fishRepo.getRui().Count - e.ammount);
                fishRepo.deleteRui(e.ammount);

                marketStore.setRui(e.ammount);
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
                // fishRepo.setKatla(fishRepo.getKatla().Count - e.ammount);
                fishRepo.deleteKatla(e.ammount);

                marketStore.setKatla(e.ammount);
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
                // fishRepo.setIlish(fishRepo.getIlish().Count - e.ammount);
                fishRepo.deleteIlish(e.ammount);
                marketStore.setIlish(e.ammount);
                Console.WriteLine("Ilish in Hatchery: " + fishRepo.getIlish());
            }
            else
            {
                Console.WriteLine("Opss! Such ammount of fish is not available.");
            }

        }

    }
}