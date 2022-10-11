using System;

namespace UltimateDSAp1
{
    public class BigO
    {
        public void log(int[] numbers)   {
        foreach (var first in numbers){
            foreach (var second in numbers)
            {
                 Console.WriteLine(first + ", " + second);
            }
        }
        }

    }
}