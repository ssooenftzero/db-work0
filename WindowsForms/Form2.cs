using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Login_Load_1(object sender, EventArgs e)
        {//随机实例化 
            Random ran = new Random();
            int number;
            char code1;
            //取五个数 
            for (int i = 0; i < 5; i++)
            {
                number = ran.Next();
                if (number % 2 == 0)
                    code1 = (char)('0' + (char)(number % 10));
                else
                    code1 = (char)('A' + (char)(number % 26)); //转化为字符 

                this.code += code1.ToString();
            }

            label5.Text = code;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
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
        public string code;
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();  //取出账号
            string password = EncryptWithMD5(textBox2.Text.Trim());  //取出密码并加密

            string myConnString = "Data Source=.;Initial Catalog=curricula_variable_system;Persist Security Info=True;User ID=sa;Password=sql";

            SqlConnection sqlConnection = new SqlConnection(myConnString);  //实例化连接对象
            sqlConnection.Open();

            string sql = "select UserID,UserPassword from SysUser where UserSchoolID = '" + username + "' and UserPassword = '" + password + "'";                                            //编写SQL命令
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows && textBox3.Text == code)
            {
                MessageBox.Show("欢迎使用！");             //登录成功
                Form13 form13 = new Form13();
                form13.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败！");
                return;
            }
            sqlDataReader.Close();
           
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //随机实例化 
            Random ran = new Random();
            int number;
            char code1;
            //取五个数 
            for (int i = 0; i < 5; i++)
            {
                number = ran.Next();
                if (number % 2 == 0)
                    code1 = (char)('0' + (char)(number % 10));
                else
                    code1 = (char)('A' + (char)(number % 26)); //转化为字符 

                this.code += code1.ToString();
            }

            label5.Text = code;
        }
    }
}
