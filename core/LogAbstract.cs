using System.Collections;
using System.Collections.Generic;
namespace Labs.core {
    public abstract class LogAbstract {

        public List<string> log = new List<string>();
        public abstract void _write();
        public abstract void _log(string str);
    }
} 