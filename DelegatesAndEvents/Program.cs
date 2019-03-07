using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
  
{
    {
        public class Program
    {
        public static void Main()
@@ -20,26 +20,23 @@ public static void Main()
                Console.ReadLine();
            }
}

public delegate int MyDelegate(out int i);

public class DelegateExercises
{
    int Method1(out int i)
    {
        System.Console.WriteLine("Method1");
        i = 10;
        i = 100;
        System.Console.WriteLine("Method1 " + i);
        return 0;
    }

    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        MyDelegate myDelegate1 = new MyDelegate(Method1);
        MyDelegate myDelegate1 = null;
        MyDelegate myDelegate2 = myDelegate + myDelegate1;
        int intValue;
        myDelegate2(out intValue);

    }
}
