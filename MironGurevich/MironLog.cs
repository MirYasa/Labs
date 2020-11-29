using System;
using System.Collections.Generic;
using ConsoleApplication1.core;

namespace ConsoleApplication1.MironGurevich {
    public class MironLog : LogAbstract, LogInterface { 
        private static MironLog instance;
       private MironLog(){}

       public static MironLog GetInstance() {
           if (instance == null) {
               instance = new MironLog();
           }
           return instance;
       }
       public void Log(string str) {
           GetInstance().log.Add(str);
       }
        public override void _write() {
            foreach (var val in base.log) {
                Console.WriteLine(val);
            }
        }
        public void Write() {
            GetInstance()._write();
        }
    }
}