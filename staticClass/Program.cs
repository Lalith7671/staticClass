using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClass
{/*
  * static keyword:
  * -classes
  * -varibles
  * -methods
  * -constructor
  * 
  * static class:
  * -a static class is declared with static keyword.
  * -it contain only static data members,static methods and a ststic constructor.
  * -it is not allowed to create objects of the static class.
  * -static classes are sealed, means one cannot inherit a static class from another class.
  */
    static class myclass     //static class
    {
        public static void add()
        {
            int a=10;
            Console.WriteLine(a);
            
        }
    }
    class myclass1    //static method
    {
        public static int a = 100;
        public string name = "surya";
        public static void display()
        {
            Console.WriteLine(a);
            myclass1 obj = new myclass1();
            Console.WriteLine(obj.name);
        }
    }
    class myclass2
    {
        public static int a = 1000;
        static myclass2()      //static constructor:it invokes only one time.
        {
            Console.WriteLine("i am lalith");
        }
        public myclass2()      // instance constructor
        {
            Console.WriteLine("i am surya");
        }
        public void num()      //method
        {
            Console.WriteLine("given static value is:" + a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myclass.add();
            myclass1.display();
            myclass2 obj = new myclass2();
            obj.num();
            Console.WriteLine(".........................................................");
            myclass2 obj1 = new myclass2();
            obj1.num();
            
        }
    }
}
