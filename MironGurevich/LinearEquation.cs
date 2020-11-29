using System;

namespace ConsoleApplication1.MironGurevich
{
    public class GetLinearEquation
    {
        public float Root (float a, float b)
        {
            if (a == 0) {
                throw new Exception("The root is not found");
            }
            return (b * -1)  / a;
        }
    }
}