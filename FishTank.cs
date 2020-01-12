using System;

namespace HatcheryManagement
{
    class FishTank
    {
        public static void GenerateFish()
        {
            FishRepo fishRepo = FishRepo.GetInstance();
            if (fishRepo.rui < 1000)
            {
                Console.WriteLine("Rui Generating: {0} pcs",(1000-fishRepo.rui));
                fishRepo.rui = 1000;
            }
            else if(fishRepo.katla < 1000)
            {
                Console.WriteLine("katla Generating: {0} pcs",(1000-fishRepo.katla));
                fishRepo.katla = 1000;
            }
            else if(fishRepo.ilish < 1000)
            {
                Console.WriteLine("Ilish Generating: {0} pcs",(1000-fishRepo.ilish));
                fishRepo.ilish = 1000;
            }
        }
    }
}