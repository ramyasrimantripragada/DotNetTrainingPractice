using System;

namespace PartialMethods
{
    public class A
    {
        void display()
        {
            Console.WriteLine("hello");
        }
    }
    public partial class PartialIncrement : A
    {
        partial void incrementNum()
        {
            Console.WriteLine("Incrementing num inside partial method");
            ++this.num;
        }

        protected virtual void protectedmethod()
        {
            Console.WriteLine("I am being called in file2 by Child2");
        }

        partial void DisplayNum();
        public void incrementNumPublic()
        {
            Console.WriteLine("Invoking partial increment Method from public method");
            this.incrementNum();
        }

        public virtual void method2()
        {
            Console.WriteLine("Method2 in Partial class in file2");
        }
    }

    public class Child2: PartialIncrement
    {
        int n;
        public Child2(int num, int n): base(num)
        {
            this.n = n;
        }
        
        public override void method2() {
            Console.WriteLine("Method2 in Child2 class in file2");
        }

    }
}
