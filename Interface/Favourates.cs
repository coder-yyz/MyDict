using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Favourates : Form
    {
        public Favourates()
        {
            InitializeComponent();
        }
        string AllWords = AccessHelper.QuerybySql("select * from MyWordsNote");
        private void Memory_Click(object sender, EventArgs e)
        {
            string sql1 = "select count(*) from MyWordsNote";
            int count = int.Parse(AccessHelper.QuerybySql(sql1));
            if(count>0)
            {
                Memory memory = new Memory();
                memory.Show();
            }
            else MessageBox.Show("没有待背的单词");

        }
         
        public void Favourates_Load(object sender, EventArgs e)
        {
            string sql1 = "select count(*) from MyWordsNote";
            for(long i = 1;i<=long.Parse(AccessHelper.QuerybySql(sql1));i++)
            {
                string sql_words = "select English from MyWordsNote where ID = "+i;
                string sql_means = "select Chinese from MyWordsNote where ID = "+i;
                string sql_note = "select Note from MyWordsNote where ID = "+i;
                textBox1.Text +=AccessHelper.QuerybySql(sql_words)+"    "+AccessHelper.QuerybySql(sql_means)+"    "+AccessHelper.QuerybySql(sql_note)+"\r\n";
            }
        }
    }
}
