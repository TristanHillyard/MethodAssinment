using System;

namespace MethodAssinment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            newMeths math = new newMeths();
            math.addMeth(num1);
            Console.WriteLine(math.addMeth(num1));
            math.decMeth(num1);
            Console.WriteLine(math.decMeth(num1));
            string num2 = "10";
            math.writtenMeth(num2);
            Console.WriteLine(math.writtenMeth(num2));

        }
    }
}
