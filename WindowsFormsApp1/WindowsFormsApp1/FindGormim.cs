using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public class FindGormim
    {
        private DecisionRishoni Calc = new DecisionRishoni();

        List<int> ListOfRisonimNumbersUntilSqrtNumberFromUser = new List<int>();

        List<int> FinalListOfGormim = new List<int>();

        public List<int> Gormim (int NumberFromUser)
        {
            FinalListOfGormim.Clear();
            FillRishonim(Math.Sqrt(NumberFromUser));
            GormimFinal(NumberFromUser);
            return FinalListOfGormim;
        }

       
        private void FillRishonim(double SqrtNumberFromUser)
        {
            for (int IndexUntilSqrtNumberFromUser = 2; IndexUntilSqrtNumberFromUser <= SqrtNumberFromUser; IndexUntilSqrtNumberFromUser++)
            {
                bool NumberIsRishoni = Calc.CheckingRishoni(IndexUntilSqrtNumberFromUser);

                if (NumberIsRishoni)
                    ListOfRisonimNumbersUntilSqrtNumberFromUser.Add(IndexUntilSqrtNumberFromUser);// Risonim numbers until the sqer (NumberFromUser)
            }
            WriteLogsForStatistics.WriteLog(String.Format("The list till squre {0} has {1} arguments", SqrtNumberFromUser, ListOfRisonimNumbersUntilSqrtNumberFromUser.Count));
        }



        private void GormimFinal(int FindGormimFromTempNumber)
        {
            int IndexOfRisonimList = 0;
            bool Rishoni =false;
            
            do
            {
                try
                {
                    if (FindGormimFromTempNumber % ListOfRisonimNumbersUntilSqrtNumberFromUser[IndexOfRisonimList] == 0)
                    {
                        FinalListOfGormim.Add(ListOfRisonimNumbersUntilSqrtNumberFromUser[IndexOfRisonimList]);
                        FindGormimFromTempNumber = FindGormimFromTempNumber / ListOfRisonimNumbersUntilSqrtNumberFromUser[IndexOfRisonimList];
                        Rishoni = Calc.CheckingRishoni(FindGormimFromTempNumber);
                    }
                    else IndexOfRisonimList++;
                }
                catch (Exception ex)
                {
                    WriteLogsForStatistics.WriteLog("Exception : " + ex.Message);
                }
            }
            while (!Rishoni);
            FinalListOfGormim.Add(FindGormimFromTempNumber);
        }
    }
}
