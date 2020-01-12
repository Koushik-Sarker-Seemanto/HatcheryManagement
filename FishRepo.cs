using System;

namespace HatcheryManagement
{
    class FishRepo
    {
        private FishRepo()
        {

        }
        private static FishRepo instance;
        public int rui = 1000, katla = 1000, ilish = 1000;
        public static FishRepo GetInstance()
        {
            if (instance == null)
            {
                instance = new FishRepo();
            }
            return instance;
        }
    }
}