using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises dhammu = new DelegateExercises();
            dhammu.Method3();
        }
    }
    public class DelegateExercises
    {
        public delegate int MyDelegate();
        void Method1() {

            System.Console.WriteLine("MyDelegate");
        }

        public void Method3()
        {

            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
        
    }
}
