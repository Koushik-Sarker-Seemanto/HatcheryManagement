using System;

namespace HatcheryManagement
{
    class FishTank
    {
        public static void GenerateFish()
        {
            FishRepo fishRepo = FishRepo.GetInstance();
            if (fishRepo.getRui() < 1000)
            {
                Console.WriteLine("Rui Generating: {0} pcs",(1000-fishRepo.getRui()));
                fishRepo.setRui(1000);
            }
            else if(fishRepo.getKatla() < 1000)
            {
                Console.WriteLine("katla Generating: {0} pcs",(1000-fishRepo.getKatla()));
                fishRepo.setKatla(1000);
            }
            else if(fishRepo.getIlish() < 1000)
            {
                Console.WriteLine("Ilish Generating: {0} pcs",(1000-fishRepo.getIlish()));
                fishRepo.setIlish(1000);
            }
        }
    }
}