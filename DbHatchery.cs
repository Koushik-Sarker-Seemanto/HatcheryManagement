using System;
using System.Collections.Generic;

namespace HatcheryManagement
{
    class DbHatchery
    {
        public List<RuiFish> ruiList = new List<RuiFish>();
        public List<KatlaFish> katlaList = new List<KatlaFish>();
        public List<IlishFish> ilishList = new List<IlishFish>();

        private static DbHatchery instance;
        private static readonly object lockCheck = new object();

        private static int count = 0;
        private DbHatchery()
        {
            count++;
            Console.WriteLine("Counter Value DBHatchery: " + count);
        }
        public static DbHatchery GetInstance()
        {
            lock (lockCheck)
            {
                if (instance == null)
                {
                    instance = new DbHatchery();
                    instance.initRui();
                    instance.initKatla();
                    instance.initIlish();
                }
                return instance;
            }
        }
        public void initRui()
        {
            for (int i = 1; i <= 1000; i++)
            {
                string name = "rui" + Convert.ToString(i);
                string weight = "rui" + Convert.ToString((i % 3));
                RuiFish rui = new RuiFish(name, weight);
                ruiList.Add(rui);
            }
        }

        public void initKatla()
        {
            for (int i = 1; i <= 1000; i++)
            {
                string name = "katla" + Convert.ToString(i);
                string weight = "katla" + Convert.ToString((i % 3));
                KatlaFish katla = new KatlaFish(name, weight);
                katlaList.Add(katla);
            }
        }
        public void initIlish()
        {
            for (int i = 1; i <= 1000; i++)
            {
                string name = "ilish" + Convert.ToString(i);
                string weight = "ilish" + Convert.ToString((i % 3));
                IlishFish ilish = new IlishFish(name, weight);
                ilishList.Add(ilish);
            }
        }
    }
}