using System;
using System.Collections.Generic;

namespace HatcheryManagement
{
    class FishRepo
    {
        private List<RuiFish> ruiList = new List<RuiFish>();
        private List<KatlaFish> katlaList = new List<KatlaFish>();
        private List<IlishFish> ilishList = new List<IlishFish>();

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
        private static int count = 0;
        private FishRepo()
        {
            count++;
            Console.WriteLine("Counter Value FishRepo " + count);
        }
        private static FishRepo instance;
        // private int rui = 1000;
        // private int katla = 1000;
        // private int ilish = 1000;

        private static readonly object lockCheck = new object();

        public static FishRepo GetInstance()
        {
            lock (lockCheck)
            {
                if (instance == null)
                {
                    instance = new FishRepo();
                    instance.initRui();
                    instance.initKatla();
                    instance.initIlish();
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
            return ruiList.Count;
        }
        public void setRui(int value)
        {
            int numofRui = ruiList.Count;
            for (int i = numofRui+1; i <= value; i++)
            {
                string name = "rui" + Convert.ToString(i);
                string weight = "rui" + Convert.ToString((i % 3));
                RuiFish rui = new RuiFish(name, weight);
                ruiList.Add(rui);
            }
        }
        public void deleteRui(int value)
        {
            int numofRui = ruiList.Count;
            for (int i = numofRui - 1; i >= (numofRui - value); i--)
            {
                ruiList.RemoveAt(i);
            }
        }
        public void deleteKatla(int value)
        {
            int numofKatla = katlaList.Count;
            for (int i = numofKatla - 1; i >= (numofKatla - value); i--)
            {
                katlaList.RemoveAt(i);
            }
        }
        public void deleteIlish(int value)
        {
            int numofIlish = ilishList.Count;
            for (int i = numofIlish - 1; i >= (numofIlish - value); i--)
            {
                ilishList.RemoveAt(i);
            }
        }
        public int getKatla()
        {
            return katlaList.Count;
        }
        public void setKatla(int value)
        {
            int numofKatla = katlaList.Count;
            for (int i = numofKatla+1; i <= value; i++)
            {
                string name = "katla" + Convert.ToString(i);
                string weight = "katla" + Convert.ToString((i % 3));
                KatlaFish katla = new KatlaFish(name, weight);
                katlaList.Add(katla);
            }
        }

        public int getIlish()
        {
            return ilishList.Count;
        }
        public void setIlish(int value)
        {
            int numofIlish = ilishList.Count;
            for (int i = numofIlish+1; i <= value; i++)
            {
                string name = "ilish" + Convert.ToString(i);
                string weight = "ilish" + Convert.ToString((i % 3));
                IlishFish ilish = new IlishFish(name, weight);
                ilishList.Add(ilish);
            }
        }
        public void PrintRui()
        {
            System.Console.WriteLine("The Final Hatchery List: Rui Fish#################");
            foreach (RuiFish rui in ruiList)
            {
                Console.WriteLine(rui.RuiName + " " + rui.RuiWeight);
            }
        }
    }
}