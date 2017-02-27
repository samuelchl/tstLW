using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public static class Mth
    {
        public static int CalculateFibonacci(int n)
        {
        
            if ((n == 0) || (n == 1)) 
                return n;
            else
                return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }

    }
}