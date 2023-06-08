using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3SystemСalculus
{
    public class Calculus
    {
        public string Calc(int a, string number)
        {
            int i = Convert.ToInt32(number);
            switch (a)
            {
                case 16:
                    return Convert.ToString(i, 16).ToUpper();
                case 8:
                    return Convert.ToString(i, 8).ToUpper();
                case 2:
                    return Convert.ToString(i, 2).ToUpper();
                default:
                    return Convert.ToString("Данная система счисления не поддерживается").ToUpper();
            }
        }
    }
}
