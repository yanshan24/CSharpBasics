using System;
using System.Collections.Generic;

namespace WebAppCoreDemo
{
    public class Department
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public string[] agents { get; set; }

    }
    public class DepartmentController
    {
        List<Department> departments = new List<Department>() {
            new Department(){ id = 1, name = "a", description = "a", agents = new string[] {"Amy", "Bob"} }
        };
        static void Main() {
            // var element = departments[0];
            // Console.WriteLine(element.id);
            foreach (var author in departments)
            {
                Console.WriteLine("Author: {0},{1},{2},{3},{4}", author.id, author.name, author.description, author.agents);
            }
        }
    }
    
}


