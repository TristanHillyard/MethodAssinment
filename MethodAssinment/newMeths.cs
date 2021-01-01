using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAssinment
{
    public class newMeths
    {
        public int addMeth(int num1)
        {
            int result;
            result = num1 + 10;
            return result;
        }
        public decimal decMeth(decimal num1)
        {
            decimal result;
            result = num1 + 4.3m;
            return result;
        }
        public int writtenMeth(string num2)
        {
            int result;
            int newResult;
            result = Convert.ToInt32(num2);
            newResult = result + 22;
            return newResult;
        }

    }
}
