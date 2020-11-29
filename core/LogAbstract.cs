using System.Collections;
using System.Collections.Generic;
namespace ConsoleApplication1.core {
    public abstract class LogAbstract {

        public List<string> log = new List<string>();
        public abstract void _write();
    }
}