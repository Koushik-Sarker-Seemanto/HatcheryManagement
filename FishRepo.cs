using System;

namespace HatcheryManagement
{
    class FishRepo
    {
        private FishRepo()
        {

        }
        private static FishRepo instance;
        private int rui = 1000;
        private int katla = 1000;
        private int ilish = 1000;
        public static FishRepo GetInstance()
        {
            if (instance == null)
            {
                instance = new FishRepo();
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