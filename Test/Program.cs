using System;
using System.Collections.Generic;

namespace Test {
    class Program {
        static void Main(string[] args) {
            var myName= "Edmund";
            Console.WriteLine("My name is " + myName + ".");
            // String interpolation, include variables in curly braces
            Console.WriteLine($"My name is {myName}.");
            // Add spacing, (20-myName.Length) spaces 
            Console.WriteLine($"My name is {myName, 20}");
            // Use an expression in string interpolation     
            Console.WriteLine($"This word, {myName}, is {(myName.Length < 10 ? "short" : "long")}.");

            List<string> names = new List<string>();
            names.Add("John".ToUpper());
            names.Add("Peter".ToLower());
            foreach(var name in names) {
                Console.WriteLine(name);
            }
        }
    }
}
