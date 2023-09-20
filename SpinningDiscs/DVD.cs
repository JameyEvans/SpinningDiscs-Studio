using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc,IOpticalDisc
    {
        public DVD (string name, int maxCapacity, string disktype, int someUsedCapacity) : base(name, maxCapacity, disktype, someUsedCapacity)
        {
        }

        public void ReadData()
        {
            Console.WriteLine("Would you like to watch a movie from this dvd?");
        }

        public void SpinDisc()
        {
            Console.WriteLine("A dvd spins at a rate of 200 - 500 rpm.");
        }
    }
}
