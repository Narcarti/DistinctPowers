using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace DistinctPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //provide total powers
            // a^b for 2 < a <=100 and 2<=b <= 100
            List<BigInteger> Total = new List<BigInteger>();
            for (int basePow = 2; basePow <= 100; basePow++)
            {
                for (int raisedPow = 2; raisedPow <= 100; raisedPow++)
                {
                    if (Total.Contains((BigInteger)Math.Pow(basePow, raisedPow)) == false) {  Total.Add((BigInteger)Math.Pow(basePow, raisedPow)); }
                }
            }
            Total.Sort((x, y) => y.CompareTo(x));

            //for (int index = 0; index < Total.Count; index++)
            //{
            //    Console.WriteLine(Total[index].ToString());
            //}
            Console.WriteLine(Total.Count);
            Console.ReadKey();
        }
    }
}
