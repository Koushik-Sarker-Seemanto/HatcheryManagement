using System;

namespace HatcheryManagement
{
    class MarketStore
    {
        private static MarketStore instance;

        private int rui = 100;
        private int katla = 100;
        private int ilish = 100;
        private MarketStore()
        {

        }
        public static MarketStore GetInstance()
        {
            if(instance == null)
            {
                instance = new MarketStore();
            }
            return instance;
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