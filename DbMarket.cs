using System;
using System.Collections.Generic;

namespace HatcheryManagement
{
    class DbMarket
    {
        // RuiRepository ruiRepository = new RuiRepository();
        
        public List<RuiFish> ruiListMarket = new List<RuiFish>();
        public List<KatlaFish> katlaListMarket = new List<KatlaFish>();
        public List<IlishFish> ilishListMarket = new List<IlishFish>();

        private static DbMarket instance;
        private static readonly object lockCheck = new object();

        private static int count = 0;
        private DbMarket()
        {
            count++;
            Console.WriteLine("Counter Value DBmarket: " + count);
        }
        public static DbMarket GetInstance()
        {
            lock (lockCheck)
            {
                if (instance == null)
                {
                    instance = new DbMarket();
                    instance.initRui();
                    instance.initKatla();
                    instance.initIlish();
                }
                return instance;
            }
        }
        public void initRui()
        {
            for (int i = 1; i <= 100; i++)
            {
                string name = "rui" + Convert.ToString(i);
                string weight = "rui" + Convert.ToString((i % 3));
                RuiFish rui = new RuiFish(name, weight);
                ruiListMarket.Add(rui);
                // ruiRepository.Insert(rui);
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
    }
}