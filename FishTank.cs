using System;

namespace HatcheryManagement
{
    class FishTank
    {
        public static int rui = 1000, katla = 1000, ilish = 1000;
        public static void GenerateFish()
        {
            if (rui < 1000 || katla < 1000 || ilish < 1000)
            {
                // Console.WriteLine("Fish Generating.");
                rui = 1000;
                katla = 1000;
                ilish = 1000;
            }
        }
    }
}