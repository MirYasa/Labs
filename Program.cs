using System;

namespace LabsCS {
    class Program {
        static void Main(string[] args) {
            var a1 = new A();
            var a2 = new A();
            var a3 = new A();
            var b4 = new B(a2, a3);
            var b5 = new B(a1, b4);
        }
    }
}