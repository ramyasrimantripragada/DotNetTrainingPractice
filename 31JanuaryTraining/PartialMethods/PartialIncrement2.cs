using System;

namespace PartialMethods
{
    public partial class PartialIncrement
    {
        partial void incrementNum()
        {
            Console.WriteLine("Incrementing num inside partial method");
            ++this.num;
        }

        partial void displayNum();
        public void incrementNumPublic()
        {
            Console.WriteLine("Invoking partial increment Method from public method");
            this.incrementNum();
        }
    }
}
