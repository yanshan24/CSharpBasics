using System;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            string[,] departments = new string[,]
            {
                { "Service", "To ensure customer satisfaction" },
                { "IT", "To develop products" },
                { "Production", "To produce products" },
                { "QualityAssurance", "To define the procedures for achieving and improving consistent product quality" },
                { "Finance", "To plan and organize the company’s finances and producing financial statements" }
            };

            int j = departments.GetLength(0);
            int i = 0;

            // for (i = 0; i < j; i++)
            // {
            //     Console.WriteLine(departments[i,0]);
            // }
            
            string[,] agents = new string[,]
            {
                { "Service", "Amy" },
                { "IT", "Bob" },
                { "Production", "C" },
                { "QualityAssurance", "D" },
                { "Finance", "E" }
            };

            departments = departments.ToList().Where(i => !departments.ElementAt(3).Equals(i)).ToArray();

            //j = arrayUpdated.GetLength(0);

            for (i = 0; i < j; i++)
            {
                Console.WriteLine(departments[i,0]);
            }
            
            Console.ReadKey();
        }
    }
}