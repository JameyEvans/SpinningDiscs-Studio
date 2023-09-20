using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD("CD example", 700, "CD-R", 350);
            DVD dvd = new DVD("DVD example", 4700, "DVD-R", 1450);
            Frisbee frisbee = new Frisbee();

            List<IOpticalDisc> discs = new List<IOpticalDisc>();
            discs.Add(cd);
            discs.Add(dvd);
            discs.Add(frisbee); 

            foreach (var disc in discs)
            {
                Console.WriteLine($"Disc Type = {disc.GetType()}");
                disc.ReadData();
                disc.SpinDisc();
                if (disc is BaseDisc baseDisc)
                {
                    Console.WriteLine(baseDisc.DiskInfo());
                }
                else
                {
                    Console.WriteLine($"{disc.GetType()} does not implement BaseDisc class.");
                }
                Console.WriteLine(Environment.NewLine);
            }

            cd.SpinDisc();
            dvd.SpinDisc();

            cd.ReadData();
            dvd.ReadData();

            Console.WriteLine(cd.WriteData(275));
            Console.WriteLine(dvd.WriteData(8000));

            Console.WriteLine(cd.DiskInfo());
            Console.WriteLine(dvd.DiskInfo());
        }
    }
}
