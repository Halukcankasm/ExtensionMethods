using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    sealed class A
    {
        public void Foo() 
        {
            Console.WriteLine("Foo");
        }
    }

    static class Ext
    {
        public static void Bar(this A hedef)
        {
            Console.WriteLine("Bar");
        }

        public static void Bar(this string hedef)
        {
            Console.WriteLine(hedef);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.Foo();
            obj.Bar();

            string str = "stringBar";
            str.Bar();
        }


    }




}
