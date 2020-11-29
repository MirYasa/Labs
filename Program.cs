using System;
using Labs.core;
using Labs.MironGurevich;
namespace Labs {
    internal class Program {
        public static void Main(string[] args) {
            var getDiscriminant = new GetQuadraticEquation();

            Console.WriteLine("Input 3 parameters");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            try {
var res2 = getDiscriminant.Roots(Convert.ToSingle(a), Convert.ToSingle(b), Convert.ToSingle(c));
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