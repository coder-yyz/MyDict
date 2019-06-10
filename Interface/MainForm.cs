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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
        
		public void Menu_Click(object sender, EventArgs e)
		{
            Menu new_menu = new Menu();
            new_menu.Show();
		}
        public void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            string sql = "update CET4 set [Note]='" + textBox1.Text +"'"+"where English='" + SearchBox.Text + "'";
            num = AccessHelper.ExecuteSql(sql);
            if (num ==1 ) MessageBox.Show("添加笔记成功");
            else MessageBox.Show("添加笔记失败");
        }

        public void Pronounce_Click(object sender, EventArgs e)
        {
            Speake.Speak(SearchBox.Text);
        }

        public void Save_Click(object sender, EventArgs e)
        {
            string sql = "insert into MyWordsNote ([English],[Chinese],[Note]) values ('" + SearchBox.Text + "','" + textBox2.Text + "','" + textBox1.Text + "')";
            string sql1 = "select count(*) from MyWordsNote where English = '" + SearchBox.Text + "'";
            if (int.Parse(AccessHelper.QuerybySql(sql1)) >= 1) MessageBox.Show("该单词已经存在");
            else
            {
                int num = AccessHelper.ExecuteSql(sql);
                if (num > 0) MessageBox.Show("收藏成功");
                else MessageBox.Show("收藏失败");
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            string sql = "select Chinese from CET4 where English ='" + SearchBox.Text + "'";
            string sql1 = "select Note from CET4 where English ='" + SearchBox.Text + "'";
            textBox2.Text = AccessHelper.QuerybySql(sql);
            textBox1.Text = AccessHelper.QuerybySql(sql1);

        }

        public void SavedItems_Click(object sender, EventArgs e)
        {
            Favourates favourates = new Favourates();
            favourates.Show();
             
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
