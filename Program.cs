using System;
using System.Collections.Generic;

namespace icecream
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> vanilla = new List<string>();
            List<string> chocolate = new List<string>();
            List<string> strawberry = new List<string>();
            Console.WriteLine("Choose ice cream flavour");
            Console.WriteLine ("1 - Vanilla, 2 - Chocolate, 3 - Strawberry");        
       
            for (int user = 1; user <= 10; user++)
            {
                
                Console.Write("User-{0} :", user);
                int input = Convert.ToInt32(Console.ReadLine());
                
                switch (input)
                {
                    case 1:
                    Console.WriteLine("You chose Vanilla");
                    Console.ReadKey(true);
                    Console.Clear();
                    vanilla.Add("Vanilla");
                    break;

                    case 2:
                    Console.WriteLine("You chose Chocolate");
                    Console.ReadKey(true);
                    Console.Clear();
                    chocolate.Add("Chocolate");
                    break;

                    case 3:
                    Console.WriteLine("You chose Strawberry");
                    Console.ReadKey(true);
                    Console.Clear();
                    strawberry.Add("Strawberry");
                    break;

                    default:
                    Console.WriteLine("Invaild choice");
                    Console.ReadKey(true);
                    Console.Clear();
                    break;

                }


            
            }
   
            Console.WriteLine("Results");
            Console.WriteLine("Vanilla - {0}", vanilla.Count);
            Console.WriteLine("Chocolate - {0}", chocolate.Count);
            Console.WriteLine("Strawberry - {0}", strawberry.Count);
            Console.ReadKey(true);

        }

        
    }
}
