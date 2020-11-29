using System;
using System.CodeDom;
using ConsoleApplication1.core;
using ConsoleApplication1.MironGurevich;

namespace ConsoleApplication1 {
    internal class Program  {
        public static void Main(string[] args)  {

            var getLinearEqusion = new GetLinearEquation();
            var getDiscriminant = new GetQuadraticEquation();

            try {
                var res = getLinearEqusion.Root(5, 1);
                Console.WriteLine($"Root form linear equation is: {res}");
            }
            catch (Exception e) {
                Console.WriteLine($"Error {e.Message}");
            }

            try {
                var res2 = getDiscriminant.Roots(1,3, 1);
                foreach (var val in res2) {
                    Console.WriteLine($"Root form quadratic equation is: {val}");
                }
            }
            catch (Exception e) {
                Console.WriteLine($"Error {e.Message}");
            }
        }
    }