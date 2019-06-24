using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class FindRishonim
    {
        public int NumbersRishonim(int NumbersRishonimUntilSqrtMumberFromUser)
        {
            if ((NumbersRishonimUntilSqrtMumberFromUser == 2) || (NumbersRishonimUntilSqrtMumberFromUser == 3))
                return NumbersRishonimUntilSqrtMumberFromUser;
            
            //for (int i = Index; i <= NumbersRishonimUntilThisNumber; i++)
            //{
                for (int j = 2; j <= Math.Sqrt(NumbersRishonimUntilSqrtMumberFromUser); j++)
                {
                    
                    if (NumbersRishonimUntilSqrtMumberFromUser % j != 0)
                    {
                        if (j + 1 > Math.Sqrt(NumbersRishonimUntilSqrtMumberFromUser))
                            return NumbersRishonimUntilSqrtMumberFromUser;
                    }
                    else break;
                }
            //}
            return 0;
        }
    }
}
