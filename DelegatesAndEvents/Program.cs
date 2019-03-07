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
            dhammu.Method2();
        }
    }
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void Method1(int i) {


            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {

            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
