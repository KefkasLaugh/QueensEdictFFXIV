using System;

namespace QueensEdict
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTheShit();
        }
        public static void DoTheShit()
        {
            Console.ForegroundColor = ConsoleColor.White;
            var South = 0;
            var North = 0;
            var West = 0;
            var IsTrueNorth = true;
            South = GetNumber("South");
            Console.WriteLine();
            West = GetNumber("West");
            Console.WriteLine();
            if (South != 3 && West != 3)
            {
                North = GetNumber("North");
                Console.WriteLine();
            }
            IsTrueNorth = GetTrueNorth();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            if (South == 3 && West < 3)
            {
                if (IsTrueNorth)
                    Console.WriteLine("5's on 4, 7's on Charlie");
                else
                    Console.WriteLine("5's on 2, 7's on Alpha");
            }
            else if (South == 3 && West == 3)
            {
                if (IsTrueNorth)
                    Console.WriteLine("5's on Charlie, 7's 2 spots to the right, DO NOT GO INTO FIRST COLUMN");
                else
                    Console.WriteLine("5's on Alpha, 7's 2 spots to the right, DO NOT GO INTO FIRST COLUMN");
            }
            else if (South < 3 && West == 3)
            {
                if (IsTrueNorth)
                    Console.WriteLine("5's on 3, 7's 2 spots to the right, DO NOT GO INTO FIRST COLUMN");
                else
                    Console.WriteLine("5's on 1, 7's 2 spots to the right, DO NOT GO INTO FIRST COLUMN");
            }
            else if (South == 1 && West < 3)
            {
                if (IsTrueNorth)
                    Console.WriteLine("5's on 4, 7's on 3");
                else
                    Console.WriteLine("5's on 2, 7's on 1");
            }
            else if (South == 2 && West < 3 && North == 1)
            {
                if (IsTrueNorth)
                    Console.WriteLine("5's on Alpha, 7's on 3");
                else
                    Console.WriteLine("5's on Charlie, 7's on 1");
            }
            else
            {
                if (IsTrueNorth)
                    Console.WriteLine("5's on Delta, 7's on 3");
                else
                    Console.WriteLine("5's on Bravo, 7's on 1");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            DoTheShit();
        }
        public static int GetNumber(string Direction)
        {
            Console.Write(string.Format("# on Robot Heading {0}: ", Direction));
            try
            {
                var res = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                if (res > 3)
                {
                    InformTheIdiotTheyreAnIdiot();
                    return GetNumber(Direction);
                }
                else
                    return res;
            }
            catch
            {
                InformTheIdiotTheyreAnIdiot();
                return GetNumber(Direction);
            }
        }
        public static bool GetTrueNorth()
        {
            Console.Write("Is the safe spot north? (1. Yes, 2. No) ");
            try
            {
                var res = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                if (res > 2)
                {
                    InformTheIdiotTheyreAnIdiot();
                    return GetTrueNorth();
                }
                else
                    return res == 1;
            }
            catch
            {
                InformTheIdiotTheyreAnIdiot();
                return GetTrueNorth();
            }
        }
        public static void InformTheIdiotTheyreAnIdiot()
        {
            Console.WriteLine();
            Console.WriteLine("That's not a valid number, idiot.");
        }
    }
}