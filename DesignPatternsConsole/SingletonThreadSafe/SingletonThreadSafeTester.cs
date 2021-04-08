using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsole.SingletonThreadSafe
{
    public static class SingletonThreadSafeTester
    {
        public static void Run()
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
            );

        }

        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
