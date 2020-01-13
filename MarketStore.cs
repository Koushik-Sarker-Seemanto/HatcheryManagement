using System;
using System.Collections.Generic;

namespace HatcheryManagement
{
    class MarketStore
    {
        private List<RuiFish> ruiListMarket = new List<RuiFish>();
        private List<KatlaFish> katlaListMarket = new List<KatlaFish>();
        private List<IlishFish> ilishListMarket = new List<IlishFish>();

        public void initRui()
        {
            for (int i = 1; i <= 100; i++)
            {
                string name = "rui" + Convert.ToString(i);
                string weight = "rui" + Convert.ToString((i % 3));
                RuiFish rui = new RuiFish(name, weight);
                ruiListMarket.Add(rui);
            }
        }

        public void initKatla()
        {
            for (int i = 1; i <= 100; i++)
            {
                string name = "katla" + Convert.ToString(i);
                string weight = "katla" + Convert.ToString((i % 3));
                KatlaFish katla = new KatlaFish(name, weight);
                katlaListMarket.Add(katla);
            }
        }
        public void initIlish()
        {
            for (int i = 1; i <= 100; i++)
            {
                string name = "ilish" + Convert.ToString(i);
                string weight = "ilish" + Convert.ToString((i % 3));
                IlishFish ilish = new IlishFish(name, weight);
                ilishListMarket.Add(ilish);
            }
        }

        private static MarketStore instance;
        private static readonly object lockCheck = new object();

        // private int rui = 100;
        // private int katla = 100;
        // private int ilish = 100;
        private static int count = 0;
        private MarketStore()
        {
            count++;
            Console.WriteLine("Counter Value MarketStore: " + count);
        }
        public static MarketStore GetInstance()
        {
            lock (lockCheck)
            {
                if (instance == null)
                {
                    instance = new MarketStore();
                    instance.initRui();
                    instance.initKatla();
                    instance.initIlish();
                }
                return instance;
            }
        }
        public int getRui()
        {
            return ruiListMarket.Count;
        }
        public void setRui(int value)
        {
            int numofRui = ruiListMarket.Count;
            for (int i = numofRui+1; i <= (numofRui+value); i++)
            {
                System.Console.WriteLine("Woooooooooooooorrrrrrrrrrkkkkkkkkkk");
                string name = "rui" + Convert.ToString(i);
                string weight = "rui" + Convert.ToString((i % 3));
                RuiFish rui = new RuiFish(name, weight);
                ruiListMarket.Add(rui);
            }
        }
        public void deleteRui(int value)
        {
            int numofRui = ruiListMarket.Count;
            System.Console.WriteLine(numofRui+" removed");
            for (int i = numofRui-1; i >= (numofRui - value); i--)
            {
                ruiListMarket.RemoveAt(i);
                System.Console.WriteLine(i+" removed");
            }
        }

        public int getKatla()
        {
            return katlaListMarket.Count;
        }
        public void setKatla(int value)
        {
            int numofRui = katlaListMarket.Count;
            for (int i = numofRui+1; i <= (numofRui+value); i++)
            {
                string name = "katla" + Convert.ToString(i);
                string weight = "katla" + Convert.ToString((i % 3));
                KatlaFish katla = new KatlaFish(name, weight);
                katlaListMarket.Add(katla);
            }
        }
        public void deleteKatla(int value)
        {
            int numofKatla = katlaListMarket.Count;
            for (int i = numofKatla - 1; i >= (numofKatla - value); i--)
            {
                katlaListMarket.RemoveAt(i);
            }
        }

        public int getIlish()
        {
            return ilishListMarket.Count;
        }
        public void setIlish(int value)
        {
            int numofIlish = ilishListMarket.Count;
            for (int i = numofIlish+1; i <= (numofIlish+value); i++)
            {
                string name = "ilish" + Convert.ToString(i);
                string weight = "ilish" + Convert.ToString((i % 3));
                IlishFish ilish = new IlishFish(name, weight);
                ilishListMarket.Add(ilish);
            }
        }
        public void deleteIlish(int value)
        {
            int numofIlish = ilishListMarket.Count;
            for (int i = numofIlish - 1; i >= (numofIlish - value); i--)
            {
                ilishListMarket.RemoveAt(i);
            }
        }

        public void PrintRuiMarket()
        {
            System.Console.WriteLine("The Final Market List: Rui Fish#################");
            foreach (RuiFish rui in ruiListMarket)
            {
                Console.WriteLine(rui.RuiName + " " + rui.RuiWeight);
            }
        }

    }
}