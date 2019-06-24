using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//david you are smart !

//Hellow Uri, TX!!
namespace WindowsFormsApp1
{
    public partial class AddSearchManualy : Form
    {
        public AddSearchManualy()
        {
            InitializeComponent();
        }
        private SearchesToDb searchToDb = new SearchesToDb();
        private void button1_Click(object sender, EventArgs e)
        {
            searchToDb.AddSearch(textBox1.Text, textBox2.Text, DateTime.Now);
        }
    }
}
