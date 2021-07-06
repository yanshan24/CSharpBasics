using System;

namespace EventApp
{
    
        public class Dog
        {
            string name;
            public delegate void Handler(); // delegate定义
            public event Handler NewDog; // 委托实例 event定义
            public Dog(string a)
            {
                name = a;
                if (NewDog != null)
                {
                    NewDog(); // call event 触发
                    printName();
                }
            }
            public void printName()
            {
                Console.WriteLine(name);
            }
        }

        public class Client
        {
            string name;
            public Client(string a)
            {
                name = a;
            }
            public void Subscribe() // 注册函数
            {
                Console.WriteLine(name + " is subscribed");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Client c1 = new Client("c1");
                Client c2 = new Client("c2");
            //     Dog.NewDog += c1.Subscribe; // 注册, if event is static
            //     Dog.NewDog += c2.Subscribe;

                Dog d = new Dog("Pecky");
                // d.NewDog += c1.Subscribe;
                // d.NewDog += c2.Subscribe;
            }
        }
    
}