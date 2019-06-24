using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private log4net.ILog log;

        public Form1()
        {
            InitializeComponent();
            InitLogger();
        }
        private int stepIndex=0;

        private const string RESULT_MESSAGE = "The Gormim of the number are: ";

        private DecisionRishoni Calc = new DecisionRishoni();

        private FindGormim Finder = new FindGormim();

        int NumberFromUser;

        private void InitLogger()
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo("log4net.config"));
            log = log4net.LogManager.GetLogger("AttendanceLog");
            long a = Properties.Settings.Default.max2;
           // log.Info("Start Application !");
            //log.Debug("Start debugging !");

        }

        private void button1_Click(object sender, EventArgs e){
          //  var settins = Application.p;
            //long a = Properties.Settings.Default.max2;
            log.InfoFormat("david's applilication started step {0}", stepIndex++);
            if (inputValidation()){

                ResultOfExercise();
                WriteLogsForStatistics.WriteLog("User search:" + textBox1.Text);
            }
            else label2.Text = ("You didn't enter valid number.");
        }

        private void ResultOfExercise()
        {
            bool Rishoni = Calc.CheckingRishoni(NumberFromUser);// Check if the number is Rishoni
            
            label2.Text = (Rishoni) ? ("The number is Rishoni") : (RESULT_MESSAGE + ConvertListToString(Finder.Gormim(NumberFromUser)));
         }   
            //if (Rishoni == true)
            //    label2.Text = ("The number is Rishoni");
            //else
            //    label2.Text = (RESULT_MESSAGE + ConvertListToString(Finder.Gormim(NumberFromUser)));

        

        private bool inputValidation()
        {
            try
            {
                log.DebugFormat("david's applilication started step {0}", stepIndex);
                NumberFromUser = Int32.Parse(textBox1.Text);
            }
            catch(Exception ex)
            {
                return false;
            }

            return NumberFromUser > 0 ? true : false;
        }

        private static string ConvertListToString(List<int> GormimRishoniim)
        {
            string s = "";
            for (int i = 0; i < GormimRishoniim.Count; i++)
            {
                s += Convert.ToString(GormimRishoniim[i]) + " ";
            }
          //  log.Infoformat ("There are: " + GormimRishoniim.Count + " Gormim");
            WriteLogsForStatistics.WriteLog("The Gormim are: " + s);
            return s;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
        //private void textbox1_textchanged(object sender, eventargs e)
        //{
        //}
    }
}
