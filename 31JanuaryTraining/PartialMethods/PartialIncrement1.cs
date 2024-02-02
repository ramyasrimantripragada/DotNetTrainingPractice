using System;
using System.Threading;

namespace PartialMethods
{

    public partial class PartialIncrement 
    {
        int num;
        public PartialIncrement(int num) {
            this.num = num; 
        }

        partial void incrementNum();

        partial void DisplayNum()
        {
            Console.WriteLine("Value of num: " + this.num);
        }

        public void displayNumPublic()
        {
            Console.WriteLine("Invoking partial display method from public");
            this.DisplayNum();

        }

        public virtual void method1()
        {
            Console.WriteLine("Method1 of Partial Class in file1");
        }
    }

    public class Child1 : PartialIncrement
    {
        int n;
        public Child1(int num, int n) : base(num)
        {
            this.n = n;
        }

        public override void method1()
        {
            base.method1();
            Console.WriteLine("Method1 of Child 1 in file1");
        }
    }
}
