using System;
using System.Collections.Generic;

namespace LoopingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var children = new List<Child>();

            //var suzie = new Child { Name = "Susie", Sick = false };
            //var ralph = new Child { Name = "Ralph", Sick = true };

            //children.Add(suzie);
            //children.Add(ralph);

            var children = new List<Child>
            {
                new Child { Name = "Susie", Sick = false },
                new Child { Name = "Ralph", Sick = true }
            };

            foreach (var child in children)
            {
                //if (child.Name == "Susie")
                //{
                //    //continue; //stop executing this iteration of the loop
                //    break; //stop executing this loop entirely and move on
                //}
                Console.WriteLine($"{child.Name} is {(child.Sick ? "sick" : "healthy")}");
                Console.WriteLine(child.ForgeASickNote());
            }

            Console.WriteLine("This is our second time talking about the same thing. #NathanIsJudgingMe");

            //Console.WriteLine($"{ralph.Name} is {(ralph.Sick ? "sick" : "healthy")}");
            //Console.WriteLine(ralph.ForgeASickNote());
            //Console.WriteLine("This is our second time talking about the same thing. #NathanIsJudgingMe");

            var lineIRead = Console.ReadLine();

        }
    }
}
