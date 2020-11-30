using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            String conn = "Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql";
            SqlConnection sqlConnection = new SqlConnection(conn);  //实例化连接对象
            String StuID = textBox1.Text.Trim();
            if(textBox1.Text=="")
            {
                MessageBox.Show("请先输入学号!");
                return;
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    String select_by_id = "select * from Student where Sno='" + StuID + "'";
                    SqlCommand sqlCommand = new SqlCommand(select_by_id, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    dataGridView1.DataSource = bindingSource;
                }
                catch
                {
                    MessageBox.Show("查询语句有误，请认真检查SQL语句!");
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请先输入学号!");
                return;
            }
            else
            {
                try
                {
                    string connString = "Data Source=.;Initial Catalog=curricula_variable_system;Persist Security Info=True;User ID=sa;Password=sql";//数据库连接字符串
                    SqlConnection connection = new SqlConnection(connString);//创建connection对象

                    //打开数据库连接
                    connection.Open();
                    //创建SQL语句
                    string sql = "select UserPhoto from SysUser where UserSchoolID = '" + textBox1.Text + "'";
                    //创建SqlCommand对象
                    SqlCommand command = new SqlCommand(sql, connection);
                    //创建DataAdapter对象
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    //创建DataSet对象
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "SysUser");
                    int c = dataSet.Tables["SysUser"].Rows.Count;
                    if (c > 0)
                    {
                        Byte[] mybyte = new byte[0];
                        mybyte = (Byte[])(dataSet.Tables["SysUser"].Rows[c - 1]["UserPhoto"]);
                        MemoryStream ms = new MemoryStream(mybyte);
                        pictureBox2.Image = Image.FromStream(ms);
                    }
                    else
                        pictureBox2.Image = null;
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String StuID = textBox1.Text.Trim();
            String conn = "Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql";
            SqlConnection sqlConnection = new SqlConnection(conn);  //实例化连接对象
            if (textBox1.Text == "")
            {
                MessageBox.Show("请先输入学号!");
                return;
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    String select_by_id = "select * from SC where Sno='" + StuID + "'";
                    SqlCommand sqlCommand = new SqlCommand(select_by_id, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    dataGridView1.DataSource = bindingSource;
                }
                catch
                {
                    MessageBox.Show("查询语句有误，请认真检查SQL语句!");
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        private void Form13_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form14 form14 = new Form14();
            form14.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String StuID = textBox1.Text.Trim();
            String conn1 = "Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql";
            SqlConnection sqlConnection1 = new SqlConnection(conn1);  //实例化连接对象
            if (textBox1.Text == "")
            {
                MessageBox.Show("请先输入学号!");
                return;
            }
            else
            {
                
                try
                {
                    sqlConnection1.Open();
                    String select_by_id1 = "select UserID,UserSchoolID,UserMobile,UserBirthday,UserIdentity from SysUser where UserSchoolID='" + StuID + "'";
                    SqlCommand sqlCommand = new SqlCommand(select_by_id1, sqlConnection1);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    dataGridView1.DataSource = bindingSource;
                }
                catch
                {
                    MessageBox.Show("查询语句有误，请认真检查SQL语句!");
                }
                finally
                {
                    sqlConnection1.Close();
                }
            }
            
        }
    }
}
