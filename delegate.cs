using System;

delegate int NumberChanger(int i);
namespace DelegateApp
{
    class Delegate
    {
        static int num = 1;

        public static int Add(int i)
        {
            num += i;
            return num;
        }
        public static int Multiply(int i)
        {
            num *= i;
            return num;
        }
        public static int GetNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            NumberChanger i = new NumberChanger(Add);
            i(10);
            Console.WriteLine(GetNum()); // 11

            NumberChanger a = null;
            a = Add;
            a(22);
            Console.WriteLine(GetNum()); // 33
            a += Multiply;
            a(2); // first Add 2, then Multiply by 2
            Console.WriteLine(GetNum());
        }
    }
}