using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    
    public class calculator
    {


        public int TwoNumbers(int a, int b)
        {
            if (a == 1)
                return 1;
            if (a == 2)
                return 2;
            if (a == 3)
                return 3;
            
            int halfNumber = 3;
            
            for (int j = 4; j <= a; j++)
            {
                for (int i = 2; i <= j/2; i++)
                {
                    if (j % i != 0)
                    {
                        if (i + 1 > j / 2)
                            halfNumber++;
                    }
                    else break;
                    
                }
            }

            return (halfNumber);
        }
    }
}
