
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using ConsoleApplication1.core;
using ConsoleApplication1.MironGurevich;

namespace ConsoleApplication1 {
    internal class Program  {
        public static void Main(string[] args)  {

            var getDiscriminant = new GetQuadraticEquation();
            var res = MironLog.GetInstance();
            Console.WriteLine("Input 3 parameters");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            try {
                var res2 = getDiscriminant.Roots(Convert.ToSingle(a),Convert.ToSingle(b), Convert.ToSingle(c));
                Console.WriteLine($"Resulting in an equation: {a}x^2 + {b}x + {c} = 0");
                foreach (var val in res2) {
                    res.Log(val.ToString());
                }
                res._write();
            }
            catch (Exception e) {
                Console.WriteLine($"Error {e.Message}");
            }
        }
    }
} 