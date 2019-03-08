using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    public class DelegateExercises
    {


        public delegate void MyDelegate();
        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate(50);
        }
    }
}
namespace DelegateAndEvents
{
    class program
    { 
    
       public static void Main(string[] args)
        {
            DelegateExercises
                delegateExercises = new DelegateExercises();
            delegateExercises.Method2();
       }
    }
    
}
