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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“curricula_variable_systemDataSet4.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.curricula_variable_systemDataSet4.Course);

        }

        private void button1_Click(object sender, EventArgs e)//插入
        {
            string Coucno = textBox1.Text.Trim();
            string Couname = textBox2.Text.Trim();
            string Coucredit = textBox3.Text.Trim();
            string Coupno = textBox4.Text.Trim();

            
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql");//定义

                try
                {
                    con.Open();//打开
                    string insertStr = "INSERT INTO  Course (Cno,Cname,Cpno,Ccredit)    " +
                        "VALUES ('" + Coucno + "','" + Couname + "','" + Coupno + "','" + Coucredit + "')";
                    SqlCommand cmd = new SqlCommand(insertStr, con);//使用
                    cmd.ExecuteNonQuery();
                }


                catch
                {
                    MessageBox.Show("输入数据违反要求!");
                }
                finally
                {
                    con.Dispose();//释放
                }
            
            this.courseTableAdapter.Fill(this.curricula_variable_systemDataSet4.Course);
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)//删除
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql");//定义
            try
            {
                con.Open();
                string select_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是Cno那列
                string delete_by_id = "delete from Course where Cno=" + select_id;//sql删除语句
                SqlCommand cmd = new SqlCommand(delete_by_id, con);
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
            this.courseTableAdapter.Fill(this.curricula_variable_systemDataSet4.Course);
        }

        private void button3_Click(object sender, EventArgs e)//根据课程号修改课程名
        {
            string Cno = textBox1.Text.Trim();
            string Cname = textBox2.Text.Trim();

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql");//定义
            try
            {
                con.Open();
                string insertStr = "UPDATE Course SET Cname = '" + Cname + "' WHERE Cno = '" + Cno + "'";
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
            this.courseTableAdapter.Fill(this.curricula_variable_systemDataSet4.Course);
        }

        private void button4_Click(object sender, EventArgs e)//根据课程号查询
        {
            string Cno = textBox1.Text.Trim();
            String conn = "Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql";
            SqlConnection sqlConnection = new SqlConnection(conn);  //实例化连接对象
            try
            {
                sqlConnection.Open();
                String select_by_id = "select * from Course where Cno='" + Cno + "'";
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

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }
    }
   
}
