using System;
public class ConstTest
{
    class SampleClass
    {
        public void swap(out int x)
        {
           x = 5; 
        }
    }

    static void Main()
    {
        SampleClass n = new SampleClass();
         /* 局部变量定义 */
         int a = 100;

         Console.WriteLine("在交换之前，a 的值： {0}", a);

         n.swap(out a);

         Console.WriteLine("在交换之后，a 的值： {0}", a);
    }
}