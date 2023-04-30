using System;
using System.Collections.Generic;

namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Stack<string> items = new Stack<string>();
            items.Push("Violin");
            items.Push("Viola");
            items.Push("Cello");
            items.Push("Bass");
            items.Push("Harp");
            
            Console.WriteLine("Would you like to search our directory for a string instrument to purchase (yes or no)");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                Console.WriteLine("Enter the name of the string instrument you would like to search for");
                string instrumentName = Console.ReadLine();
                if (items.Contains(instrumentName))
                {
                    Console.WriteLine("That instrument is available.");
                }
                else
                {
                    Console.WriteLine("I am sorry, that instrument is not available");
                }
                Console.WriteLine("Would you like to look for another instrument (yes or no)");
                answer = Console.ReadLine();
            }
            
            Console.WriteLine($"Here are the available options: {items.Count()} items");
            
            foreach (var i in items)
            {
                Console.WriteLine(i);
            }
            string instrument = items.Peek();   
            Console.WriteLine($"Would you like to remove {instrument} from the end of the Stack (yes or no)?");
            answer = Console.ReadLine();
            while (answer == "yes")
            {
                items.Pop();  
                instrument = items.Peek();
                Console.WriteLine($"Would you like to remove {instrument} from the end of the Stack (yes or no)?");
                answer = Console.ReadLine();
            }

            if (items.Peek() == null)
                Console.WriteLine("The Stack is empty");
            else
                Console.WriteLine($"You have {items.Count} left in the Stack");

        }
    }
}

