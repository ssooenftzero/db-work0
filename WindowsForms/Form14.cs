using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        public static string EncryptWithMD5(string source)
        {
            byte[] sor = Encoding.UTF8.GetBytes(source);
            MD5 md5 = MD5.Create();
            byte[] result = md5.ComputeHash(sor);
            StringBuilder strbul = new StringBuilder(40);
            for (int i = 0; i < result.Length; i++)
            {
                strbul.Append(result[i].ToString("x2"));//加密结果"x2"结果为32位,"x3"结果为48位,"x4"结果为64位
            }
            return strbul.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("学号不能为空！");
            }
            if(textBox1.Text=="")
            {

                MessageBox.Show("新密码不能为空！");
            }
            if (textBox2.Text == "")
            {

                MessageBox.Show("确认密码不能为空！");
            }
            if(textBox1.Text.Trim()!="")//新密码不为空时，输入满足正则表达式
            {
                //使用regex（正则表达式）进行格式设置 至少有数字、大写字母、小写字母各一个。最少3个字符、最长20个字符。
                Regex regex = new Regex(@"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{3,20}");
                if (regex.IsMatch(textBox1.Text))//判断格式是否符合要求
                {
                    //MessageBox.Show("输入密码格式正确!");
                }
                else
                {
                    MessageBox.Show("至少有数字、大写字母、小写字母各一个。最少3个字符、最长20个字符！");
                    return;
                }
            }
            if (textBox1.Text == textBox2.Text)
            {
                string sql = "update SysUser set UserPassWord='"+ EncryptWithMD5(textBox1.Text)+"' where UserSchoolID='"+ textBox3.Text.Trim()+"'";
                string connString = "Data Source=.;Initial Catalog=curricula_variable_system;Persist Security Info=True;User ID=sa;Password=sql";
                SqlConnection con = new SqlConnection(connString);//创建connection对象
                con.Open();
                SqlCommand command = new SqlCommand(sql, con);

                command.ExecuteNonQuery();
                MessageBox.Show("新密码已经修改完成");
                
                con.Close();
            }
            else
            {
                MessageBox.Show("请输入两次相同的密码");
            }

            
        }

        private void Form14_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
