using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1.MironGurevich
{
    public class GetQuadraticEquation : GetLinearEquation
    {
        protected float GetDiscriminant (float a, float b, float c) {
            return b * b - 4 * a * c;
        }
        public List<float> Roots (float a, float b, float c) {
            if (a == 0) {
                 return new List<float>(){(base.Root(b, c))};
            }
            float d = GetDiscriminant(a, b, c);

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