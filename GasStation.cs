using System;

namespace GasStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] gas = new int[4] {4,6,7,4 };

            int[] cost = new int[4] { 6, 5, 3, 5 };
            int def=0, start=0, tank = 0;
            for(int i=0; i< gas.Length; i++)
            {
                tank += gas[i] - cost[i];
                if(tank < 0)
                {
                    start = i + 1;
                    def += tank;
                    tank = 0;
                }
            }

            Console.WriteLine(tank + def > 0 ? start : -1);
            Console.ReadLine();
        }
    }
}
