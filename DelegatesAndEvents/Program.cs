using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    using System;

    delegate void ExampleDelegate(string xyz);

    class Program
    {
        public static void Method1(string xyz)
        public class Program
        {
            Console.WriteLine(xyz + " Method1");
            public static void Main()
            {
                DelegateExercises delegateExercises = new DelegateExercises();
                delegateExercises.Method3();
                Console.ReadLine();
            }
        }

        public static void Method2(string xyz)
        {
            Console.WriteLine(xyz + " Method2");
        }
        public delegate int MyDelegate(out int i);

        public static void Main()
        public class DelegateExercises
        {
            ExampleDelegate ex1Delegate, ex2Delegate, ex3Delegate, myDelegate;
            int Method1(out int i)
            {
                System.Console.WriteLine("Method1");
                i = 10;
                return 0;
            }

            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                MyDelegate myDelegate1 = new MyDelegate(Method1);
                MyDelegate myDelegate2 = myDelegate + myDelegate1;
                int intValue;
                myDelegate2(out intValue);

                ex1Delegate = new ExampleDelegate(Method1);
                ex2Delegate = new ExampleDelegate(Method2);
                ex3Delegate = ex1Delegate + ex2Delegate;
                myDelegate = ex1Delegate - ex2Delegate;
                ex1Delegate("AAA");
                ex2Delegate("BBB");
                ex3Delegate("CCC");
                myDelegate("DDD");
                myDelegate = ex3Delegate - ex1Delegate;
                myDelegate("EEE");
                myDelegate = ex3Delegate - ex2Delegate;
                myDelegate("FFF");
                Console.ReadLine();
            }
        }
    }
}

    }