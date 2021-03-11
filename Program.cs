using System;
using Lab.core;
using Lab.MironGurevich;
using System.IO;

namespace Lab {
    internal class Program {
        public static void Main(string[] args) {
            var getDiscriminant = new GetQuadraticEquation();

            StreamReader sr = new StreamReader("version");
            string sContext = sr.ReadToEnd();
            sr.Close();
            MironLog.Log($"Programm version: {sContext.Trim()}");

            Console.WriteLine("Input 3 parameters");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            try {
                var res2 = getDiscriminant.Solve(Convert.ToSingle(a), Convert.ToSingle(b), Convert.ToSingle(c));
                Console.WriteLine($"Equation: {a}x^2 + {b}x + {c} = 0");

                MironLog.Log("Roots: " + String.Join(" ,", res2));
            }
            catch (Exception e) {
                MironLog.Log($"Error {e.Message}");
            }
            MironLog.Write();


        }
    }
}