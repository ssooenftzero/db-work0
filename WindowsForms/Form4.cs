using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public Byte[] mybyte = new byte[0];


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void button3_Click(object sender, EventArgs e)
        {
            //打开浏览图片对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string picturePath = openFileDialog.FileName;//获取图片路径
            //文件的名称，每次必须更换图片的名称，这里很为不便
            //创建FileStream对象
            FileStream fs = new FileStream(picturePath, FileMode.Open, FileAccess.Read);
            //声明Byte数组
            mybyte = new byte[fs.Length];
            //读取数据
            fs.Read(mybyte, 0, mybyte.Length);
            pictureBox1.Image = Image.FromStream(fs);
            fs.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Data Source=.;Initial Catalog=curricula_variable_system;Persist Security Info=True;User ID=sa;Password=sql";//数据库连接字符串
                SqlConnection connection = new SqlConnection(connString);//创建connection对象
                string sql = "insert into SysUser (UserID,   UserPassWord ,   UserSchoolID, UserMobile, UserBirthday , UserIdentity , UserPhoto ) " +
                                                        "values (@userid, @userpassword,@userschoolid,@usermobile,@userbirthday,@useridentity,@userphoto)";
              
                SqlCommand command = new SqlCommand(sql, connection);

                SqlParameter sqlParameter = new SqlParameter("@userid", textBox8.Text);
                command.Parameters.Add(sqlParameter);
                
                sqlParameter = new SqlParameter("@userpassword", EncryptWithMD5(textBox7.Text));
                command.Parameters.Add(sqlParameter);
                
                sqlParameter = new SqlParameter("@userschoolid", textBox6.Text);
                command.Parameters.Add(sqlParameter);
                
                sqlParameter = new SqlParameter("@usermobile", textBox5.Text);
                command.Parameters.Add(sqlParameter);
                
                sqlParameter = new SqlParameter("@userbirthday", dateTimePicker2.Value);
                command.Parameters.Add(sqlParameter);
                
                sqlParameter = new SqlParameter("@useridentity", comboBox1.Text);
                command.Parameters.Add(sqlParameter);
                
                sqlParameter = new SqlParameter("@userphoto", SqlDbType.VarBinary, mybyte.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mybyte);
                command.Parameters.Add(sqlParameter);
                

                //打开数据库连接
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("注册成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
