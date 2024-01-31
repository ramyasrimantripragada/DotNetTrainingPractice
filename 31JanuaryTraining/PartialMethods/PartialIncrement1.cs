using System;

namespace PartialMethods
{
    public partial class PartialIncrement
    {
        int num;
        public PartialIncrement(int num) {
            this.num = num; 
        }

        partial void incrementNum();

        partial void displayNum()
        {
            Console.WriteLine("Value of num: " + this.num);
        }

        public void displayNumPublic()
        {
            Console.WriteLine("Invoking partial display method from public");
            this.displayNum();
        }
    }
}
