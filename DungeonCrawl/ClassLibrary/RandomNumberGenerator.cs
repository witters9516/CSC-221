using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ClassLibrary
{
    public static class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider generate = new RNGCryptoServiceProvider();

        public static int MidValue(int minValue, int maxValue)
        {
            //number[] randomNumber = new number[1];

            //generate.GetNumber(randomNumber);

            //double randomValue = Convert.ToDouble(randomNumber[0]);

            //double multiplier = Math.Max(0, (randomValue / 255d) - 0.00000000001d);

            //int range = maxValue - minValue + 1;

            //double rangeValue = Math.Floor(multiplier * range);

            //return (int)(minValue + randomValue);
            return 0;
        }
    }
}
