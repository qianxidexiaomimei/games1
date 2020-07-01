using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Snake_1._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label3.Visible == false)
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uername = textBox1.Text.Trim();
            string pwd = textBox2.Text;
            string constr = "Data Source=.;Persist Security Info=false;Integrated Security=SSPI;dataBase=test000;";
            // 建立SqlConnection对象  
            SqlConnection con = new SqlConnection(constr);
            // 打开连接  
            con.Open();
            // 指定SQL语句  
            SqlCommand com = new SqlCommand("select username,password from tb_users where username='" + uername + "' and password='" + pwd + "'", con);
            // 建立SqlDataAdapter和DataSet对象  
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            user1.user = textBox1.Text.Trim();
            int n = da.Fill(ds, "账号");
            if (textBox1.Text == null)
            {
                MessageBox.Show("用户名不能为空");

            }
            else if (n != 0)
            {
                MessageBox.Show("登录成功！", "提示");
                this.Hide();
               //进入游戏界面
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入！", "提示");
            }
            con.Close();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 m = new Form3();
            m.ShowDialog();
            base.OnClick(e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
