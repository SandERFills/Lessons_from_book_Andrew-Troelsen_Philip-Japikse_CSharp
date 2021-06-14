using System;
using static System.Console;
using static System.DateTime;

namespace StaticClassLesson
{
   static class TimeOut
    {
        public static void PrintTime()=>WriteLine(Now.ToShortTimeString());
        
        public static void PrintDate()=>WriteLine(Today.ToShortDateString());
        

    }
}
