using System;
using System.Collections.Generic;

namespace HatcheryManagement
{
    class MarketStore
    {
        DbMarket dbMarket = DbMarket.GetInstance();
        Repository repository = new Repository();
        public int getRui()
        {
            return repository.GetAll<RuiFish>().Count;
        }
        public void setRui(int value)
        {
            int numofRui = dbMarket.ruiListMarket.Count;
            for (int i = numofRui+1; i <= (numofRui+value); i++)
            {
                string name = "rui" + Convert.ToString(i);
                string weight = "rui" + Convert.ToString((i % 3));
                RuiFish rui = new RuiFish(name, weight);
                // dbMarket.ruiListMarket.Add(rui);
                // ruiRepository.Insert(rui);
                repository.Insert<RuiFish>(rui);
            }
        }
        public void deleteRui(int value)
        {
            int numofRui = dbMarket.ruiListMarket.Count;
            for (int i = numofRui-1; i >= (numofRui - value); i--)
            {
                // dbMarket.ruiListMarket.RemoveAt(i);
                // ruiRepository.Delete(i);
                repository.Delete<RuiFish>(i);
            }
        }

        public int getKatla()
        {
            // return katlaRepository.GetAll().Count;
            return repository.GetAll<KatlaFish>().Count;
        }
        public void setKatla(int value)
        {
            int numofRui = dbMarket.katlaListMarket.Count;
            for (int i = numofRui+1; i <= (numofRui+value); i++)
            {
                string name = "katla" + Convert.ToString(i);
                string weight = "katla" + Convert.ToString((i % 3));
                KatlaFish katla = new KatlaFish(name, weight);
                // dbMarket.katlaListMarket.Add(katla);
                // katlaRepository.Insert(katla);
                repository.Insert<KatlaFish>(katla);
            }
        }
        public void deleteKatla(int value)
        {
            int numofKatla = dbMarket.katlaListMarket.Count;
            for (int i = numofKatla - 1; i >= (numofKatla - value); i--)
            {
                // dbMarket.katlaListMarket.RemoveAt(i);
                // katlaRepository.Delete(i);
                repository.Delete<KatlaFish>(i);
            }
        }

        public int getIlish()
        {
            return repository.GetAll<IlishFish>().Count;
        }
        public void setIlish(int value)
        {
            int numofIlish = dbMarket.ilishListMarket.Count;
            for (int i = numofIlish+1; i <= (numofIlish+value); i++)
            {
                string name = "ilish" + Convert.ToString(i);
                string weight = "ilish" + Convert.ToString((i % 3));
                IlishFish ilish = new IlishFish(name, weight);
                // dbMarket.ilishListMarket.Add(ilish);
                repository.Insert<IlishFish>(ilish);
            }
        }
        public void deleteIlish(int value)
        {
            int numofIlish = dbMarket.ilishListMarket.Count;
            for (int i = numofIlish - 1; i >= (numofIlish - value); i--)
            {
                // dbMarket.ilishListMarket.RemoveAt(i);
                repository.Delete<IlishFish>(i);
            }
        }

        public void PrintRuiMarket()
        {
            System.Console.WriteLine("The Final Market List: Rui Fish#################");
            foreach (RuiFish rui in dbMarket.ruiListMarket)
            {
                Console.WriteLine(rui.Name + " " + rui.Weight);
            }
        }

    }
}