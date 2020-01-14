using System;
using System.Collections.Generic;

namespace HatcheryManagement
{
    class FishRepo
    {   
        DbHatchery dbHatchery;
        private static int count = 0;
        private FishRepo()
        {
            dbHatchery = DbHatchery.GetInstance();
            count++;
            Console.WriteLine("Counter Value FishRepo " + count);
        }
        private static FishRepo instance;

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
            System.Console.WriteLine("Current Thread FishRepo: " + message);
        }
        public int getRui()
        {
            return dbHatchery.ruiList.Count;
        }
        public void setRui(int value)
        {
            int numofRui = dbHatchery.ruiList.Count;
            for (int i = numofRui+1; i <= value; i++)
            {
                string name = "rui" + Convert.ToString(i);
                string weight = "rui" + Convert.ToString((i % 3));
                RuiFish rui = new RuiFish(name, weight);
                dbHatchery.ruiList.Add(rui);
            }
        }
        public void deleteRui(int value)
        {
            int numofRui = dbHatchery.ruiList.Count;
            for (int i = numofRui - 1; i >= (numofRui - value); i--)
            {
                dbHatchery.ruiList.RemoveAt(i);
            }
        }
        public void deleteKatla(int value)
        {
            int numofKatla = dbHatchery.katlaList.Count;
            for (int i = numofKatla - 1; i >= (numofKatla - value); i--)
            {
                dbHatchery.katlaList.RemoveAt(i);
            }
        }
        public void deleteIlish(int value)
        {
            int numofIlish = dbHatchery.ilishList.Count;
            for (int i = numofIlish - 1; i >= (numofIlish - value); i--)
            {
                dbHatchery.ilishList.RemoveAt(i);
            }
        }
        public int getKatla()
        {
            return dbHatchery.katlaList.Count;
        }
        public void setKatla(int value)
        {
            int numofKatla = dbHatchery.katlaList.Count;
            for (int i = numofKatla+1; i <= value; i++)
            {
                string name = "katla" + Convert.ToString(i);
                string weight = "katla" + Convert.ToString((i % 3));
                KatlaFish katla = new KatlaFish(name, weight);
                dbHatchery.katlaList.Add(katla);
            }
        }

        public int getIlish()
        {
            return dbHatchery.ilishList.Count;
        }
        public void setIlish(int value)
        {
            int numofIlish = dbHatchery.ilishList.Count;
            for (int i = numofIlish+1; i <= value; i++)
            {
                string name = "ilish" + Convert.ToString(i);
                string weight = "ilish" + Convert.ToString((i % 3));
                IlishFish ilish = new IlishFish(name, weight);
                dbHatchery.ilishList.Add(ilish);
            }
        }
        public void PrintRui()
        {
            System.Console.WriteLine("The Final Hatchery List: Rui Fish#################");
            foreach (RuiFish rui in dbHatchery.ruiList)
            {
                Console.WriteLine(rui.Name + " " + rui.Weight);
            }
        }
    }
}