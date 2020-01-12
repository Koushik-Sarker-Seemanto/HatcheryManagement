using System;

namespace HatcheryManagement
{
    class FishRepo
    {
        private static int count = 0;
        private FishRepo()
        {
            count++;
            Console.WriteLine("Counter Value " + count);
        }
        private static FishRepo instance;
        private int rui = 1000;
        private int katla = 1000;
        private int ilish = 1000;

        private static readonly object lockCheck = new object();

        public static FishRepo GetInstance()
        {
            lock (lockCheck)
            {
                if (instance == null)
                {
                    instance = new FishRepo();
                }
                return instance;
            }
        }
        public void threadDetails(string message)
        {
            System.Console.WriteLine("Current Thread: "+message);
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