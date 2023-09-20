using System;
namespace SpinningDiscs
{
    public class Frisbee : IOpticalDisc
    {
        public Frisbee ()
        {
        }

        public void ReadData()
        {
            Console.WriteLine("You can't read data from a frisbee");
        }

        public void SpinDisc()
        {
            Console.WriteLine("Frisbee is thrown...but not very far.");
        }
    }
}
