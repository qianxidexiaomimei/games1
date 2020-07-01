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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string uername = txtUserName.Text.Trim();
            string pwd1 = textBox3.Text;
            string pwd2 = textBox4.Text;
            string sqlist = "select username,password from tb_users where username='" + uername + "' and password='" + pwd1 + "'";
            //将地址赋给constr
            string constr = "Data Source=.;Persist Security Info=false;Integrated Security=SSPI;dataBase=test000;";
            // 建立SqlConnection对象
            SqlConnection con = new SqlConnection(constr);
            //打开连接
            con.Open();
            // 指定SQL语句 
            SqlCommand sqlcom = new SqlCommand(sqlist, con);
            // 建立SqlDataAdapter和DataSet对象

            SqlDataAdapter da = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();

            int n = da.Fill(ds, "tb_users");
            if (n != 0)
            {
                MessageBox.Show("用户名已存在！", "提示");
                txtUserName.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else if (txtUserName.TextLength > 10)
            {
                MessageBox.Show("用户名太长！", "提示");
                txtUserName.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("两次输入的密码不一致！", "提示");
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("用户名或密码不能为空！", "提示");
            }

            else
            {
                // 指定SQL语句  
                sqlcom = new SqlCommand("insert into tb_users(username,password,score) values ('"
                    + txtUserName.Text + "','" + textBox3.Text + "','0')", con);

                // 建立SqlDataAdapter和DataSet对象 
                //sqlcom = null;
                DialogResult dr = MessageBox.Show("是否确认注册？", "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    sqlcom.ExecuteNonQuery();
                    MessageBox.Show("注册成功！", "提示");
                    this.Hide();
                    Form2 p = new Form2();
                    p.ShowDialog();
                }
                else if (dr == DialogResult.Cancel)
                {
                    this.Hide();
                    Form2 p = new Form2();
                    p.ShowDialog();
                }
                this.Close();
            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 m1 = new Form2();
            m1.ShowDialog();
        }
    }
}
