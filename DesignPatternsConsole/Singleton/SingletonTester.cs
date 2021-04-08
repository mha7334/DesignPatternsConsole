using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.Singleton
{
    public static class SingletonTester
    {
        public static void Run()
        {
            Singleton fromTeachaer = Singleton.GetInstance;
            fromTeachaer.PrintDetails("From Teacher");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");

        }
    }
}
