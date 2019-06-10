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
	public partial class Memory : Form
	{
		public Memory()
		{
			InitializeComponent();
		}
        public int num = 20;
        private void Memory_Load(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            string sql1 = "select count(*) from MyWordsNote";
            int count = int.Parse(AccessHelper.QuerybySql(sql1));
            if (count < 20) num = count;
            Process.Text = num.ToString();
            if (count >= 1)
            {
                int id = rand.Next(1, count+1);
                string sql_ch = "select Chinese from MyWordsNote where ID =" + id;
                string sql_en = "select English from MyWordsNote where ID =" + id;
                textBox1.Text = AccessHelper.QuerybySql(sql_en) + "\r\n" + AccessHelper.QuerybySql(sql_ch);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num--;
            if (num >= 0)
            {
                Process.Text = num.ToString();
                string[] str = textBox1.Text.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string sql = "delete from MyWordsNote where [English] ='" + str[0] + "'";
                AccessHelper.ExecuteSql(sql);
                MessageBox.Show(AccessHelper.ExecuteSql(sql).ToString());
                Random rand = new Random(DateTime.Now.Millisecond);
                string sql1 = "select count(*) from MyWordsNote";
                int count = int.Parse(AccessHelper.QuerybySql(sql1));
                if (count >= 1)
                {
                    int id = rand.Next(1, count + 1);
                    string sql_ch = "select Chinese from MyWordsNote where ID =" + id;
                    string sql_en = "select English from MyWordsNote where ID =" + id;
                    textBox1.Text = AccessHelper.QuerybySql(sql_en) + "\r\n" + AccessHelper.QuerybySql(sql_ch);
                }
            }
            else MessageBox.Show("单词已经背完");
           
        }

        private void Pronounce_Click(object sender, EventArgs e)
        {
            string[] str = textBox1.Text.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Speake.Speak(str[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            string sql1 = "select count(*) from MyWordsNote";
            int count = int.Parse(AccessHelper.QuerybySql(sql1));
            if (count >= 1)
            {
                int id = rand.Next(1, count+1);
                string sql_ch = "select Chinese from MyWordsNote where ID =" + id;
                string sql_en = "select English from MyWordsNote where ID =" + id;
                textBox1.Text = AccessHelper.QuerybySql(sql_en) + "\r\n" + AccessHelper.QuerybySql(sql_ch);
            }
        }
    }
}
