using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“curricula_variable_systemDataSet7.SC”中。您可以根据需要移动或删除它。
            this.sCTableAdapter2.Fill(this.curricula_variable_systemDataSet7.SC);

            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)//查询
        {
            string StuID = textBox1.Text.Trim();
            String conn = "Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql";
            SqlConnection sqlConnection = new SqlConnection(conn);  //实例化连接对象
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

        private void button4_Click(object sender, EventArgs e)//根据学号课程号修改成绩
        {
            string StuID = textBox1.Text.Trim();
            string Cno = textBox2.Text.Trim();
            string Grade = textBox3.Text.Trim();

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql");//定义
            try
            {
                con.Open();
                string insertStr = "UPDATE SC SET Grade = '" + Grade + "' WHERE Cno = '" + Cno + "'AND Sno='"+ StuID+"'";
                SqlCommand cmd = new SqlCommand(insertStr, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("输入数据违反要求!");
            }
            finally
            {
                con.Dispose();
            }
            this.sCTableAdapter2.Fill(this.curricula_variable_systemDataSet7.SC);
        }

        private void button2_Click(object sender, EventArgs e)//添加
        {
            string StuID = textBox1.Text.Trim();
            string Cno = textBox2.Text.Trim();
            string Grade = textBox3.Text.Trim();

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql");//定义
            try
            {
                string stu = "select Sno from Student where Sno='" + StuID + "'";
                if (stu != "")
                {
                    con.Open();//打开
                    string insertStr = "INSERT INTO  SC (Sno,Cno,Grade)    " +
                        "VALUES ('" + StuID + "','" + Cno + "','" + Grade + "')";
                    SqlCommand cmd = new SqlCommand(insertStr, con);//使用
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("没有该学生！请重新输入");
                }
                

            }
            catch
            {

                MessageBox.Show("输入数据违反要求!");//新加的学号在已有学号中,课程号在已有的课程中，成绩在0到100之间
            }
            finally
            {
                con.Dispose();//释放
            }
            this.sCTableAdapter2.Fill(this.curricula_variable_systemDataSet7.SC);
        }

        private void button3_Click(object sender, EventArgs e)//删除
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql");//定义
            try
            {
                con.Open();
                string StuID = textBox1.Text.Trim();
                string Cno = textBox2.Text.Trim();
                string delete_by_stc= "delete from SC where Sno='"+ textBox1.Text + "' and Cno='" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(delete_by_stc, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("请正确选择行!");
            }
            finally
            {
                con.Dispose();
            }
            this.sCTableAdapter2.Fill(this.curricula_variable_systemDataSet7.SC);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text= null;
            textBox2.Text = null;
            textBox3.Text = null;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
