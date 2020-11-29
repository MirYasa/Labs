using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleApplication1.core;

namespace ConsoleApplication1.MironGurevich
{
    public class GetQuadraticEquation : GetLinearEquation, EquationInterface
    {
        protected float GetDiscriminant (float a, float b, float c) {
            return b * b - 4 * a * c;

            if (d < 0) {
                throw new Exception("The roots in not found");

            }  
            if (d == 0) {
                return new List<float>() {-b / (2 * a)};
            }  
            return new List<float>() {(-b + (float)Math.Sqrt(d)) / (2 * a), (-b - (float)Math.Sqrt(d)) / (2 * a)};
        }
    }
}