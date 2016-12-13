using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yavorynskyylab1
{
    public class Anima
    {
        double a, b;

        public Anima(double a1, double b1)
        {


            a = a1;
            b = b1;
        }
        public double suma()
        {
            return a + b;
        }
        public double rizn()
        {
            return a - b;
        }
        public double dobu()
        {
            return a * b;
        }
        public double chas()
        {
            return a / b;
        }
    }
}