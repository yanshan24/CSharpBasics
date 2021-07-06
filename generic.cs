using System;
using System.Collections.Generic;

namespace GenericPractice
{
    public class Dog{
        string name;
        public Dog(string a)
        {
            name = a;
        }
        public void printName()
        {
            Console.WriteLine(name);
        }
    }
    public class Cage<T>
    {
        // static void Swap<T>(ref T a, ref T b)
        // {
        //     T temp;
        //     temp = a;
        //     a = b;
        //     b = temp;
        // }

        // static void Main(string[] args)
        // {
        //     int a = 1;
        //     int b = 2;
        //     Console.WriteLine("before swap: a = " + a + ", b = " + b);
        //     Swap(ref a, ref b);
        //     Console.WriteLine("after swap: a = " + a + ", b = " + b);
        // }
        int size;
        int count;
        T[] array;
        public Cage(int i)
        {
            size = i;
            count = 0;
            array = new T[size];
        }
        public void newItem(T item)
        {
            if (count < size)
            {
                array[count] = item;
                count++;
            }
            else
            {
                Console.WriteLine("Cage is full.");
            }
        }
        public T popItem()
        {
            if (count > 0)
            {
                
                T item = array[count-1];
                count--;
                return item;
            }
            else
            {
                return default(T);
                Console.WriteLine("Cage is empty.");
            }
        }
        public void printCount()
        {
            Console.WriteLine(count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cage<Dog> dogCage = new Cage<Dog>(5); // var works too
            dogCage.newItem(new Dog("dog1"));
            dogCage.newItem(new Dog("dog2"));
            dogCage.printCount();
            Dog d = dogCage.popItem();
            d.printName();
            dogCage.printCount();
        }
    }
}