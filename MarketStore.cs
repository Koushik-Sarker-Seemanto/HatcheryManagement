using System;

namespace HatcheryManagement
{
    class MarketStore
    {
        private static MarketStore instance;
        private static readonly object lockCheck = new object();

        private int rui = 100;
        private int katla = 100;
        private int ilish = 100;
        private static int count = 0;        
        private MarketStore()
        {
            count++;
            Console.WriteLine("Counter Value " + count);
        }
        public static MarketStore GetInstance()
        {
            lock (lockCheck)
            {
                if (instance == null)
                {
                    instance = new MarketStore();
                }
                return instance;
            }
        }
        public int getRui()
        {
            return rui;
        }
        public void setRui(int value)
        {
            rui = value;
        }

        public int getKatla()
        {
            return katla;
        }
        public void setKatla(int value)
        {
            katla = value;
        }

        public int getIlish()
        {
            return ilish;
        }
        public void setIlish(int value)
        {
            ilish = value;
        }

    }
}