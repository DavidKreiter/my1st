using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DecisionRishoni
    {
        /*public int CheckingRishoni(int NumberThatChecking)
        {
            if (NumberThatChecking<4)
            return NumberThatChecking;//Rishoni 

            bool Rishoni = true;
            
            for (int i = 2; i <= Math.Sqrt(NumberThatChecking); i++)
            {
                if (NumberThatChecking % i == 0)
                {
                    Rishoni = false;
                    break;
                }
                else
                {
                    if (i + 1 > Math.Sqrt(NumberThatChecking))
                        Rishoni = true;
                }
            }
            if (Rishoni == false)
                return 0;   //Not Rishoni 
            else return NumberThatChecking;  //Rishoni 
        }*/


        //public int y;
        public bool CheckingRishoni(int NumberThatChecking){
            if (NumberThatChecking < 4)
                return true;//Rishoni 

            for (int i = 2; i <= Math.Sqrt(NumberThatChecking); i++){
                if (NumberThatChecking % i == 0){
                    return false;
                }
                else{
                    if (i + 1 > Math.Sqrt(NumberThatChecking))
                        return true;
                }
            }
            return true;
        }
    }
}