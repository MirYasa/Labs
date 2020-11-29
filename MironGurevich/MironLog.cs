using System;
using Labs.core;
namespace Labs.MironGurevich {
    public class MironLog : LogAbstract, LogInterface { 
        private static MironLog instance;
       private MironLog(){}
       public static MironLog GetInstance() {
           if (instance == null) {
               instance = new MironLog();
           }
           return instance;
       }
	 public static void Log(string str) {
           GetInstance()._log(str);
       }
        public override void _write() {
		var result = String.Join("\r\n", log);
            Console.WriteLine(result);
        }

        public override void _log(string str) {
            GetInstance().log.Add(str);
        }

        public static void Write() {
            GetInstance()._write();
        }
    }
}