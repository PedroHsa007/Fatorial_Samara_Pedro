using Fatorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    public class Fatorar
    {
        public static int Calcular(int num)
        {
            if ((num == 0) || (num == 1))
            {
                return 1;
            }
            else
            {
                return num * Calcular(num - 1);
            }
        }
    }
}