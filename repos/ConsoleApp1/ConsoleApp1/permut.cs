using System;


namespace ConsoleApp1
{
    class permut
    {
        public static int a;
        public static int b;
        public static int c;
        static void Main()
        {
            a = 5;
            b = 4;

            c = a;
            a = b;
            b = c;

            Console.WriteLine(a+","+b+","+c);

        }
    }
}
