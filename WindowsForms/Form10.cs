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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“curricula_variable_systemDataSet3.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.curricula_variable_systemDataSet3.Student);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            String StuID = textBox1.Text.Trim();
            String StuName = textBox2.Text.Trim();
            String StuSex = textBox3.Text.Trim();
            String StuAge = textBox4.Text.Trim();
            String StuSdept = textBox5.Text.Trim();

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql");//定义
            try
            {
                con.Open();//打开
                string insertStr = "INSERT INTO  Student (Sno,Sname,Ssex,Sage,Sdept)    " +
                    "VALUES ('" + StuID + "','" + StuName + "','" + StuSex + "'," + StuAge + ",'" + StuSdept + "')";
                SqlCommand cmd = new SqlCommand(insertStr, con);//使用
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("输入数据违反要求!");//新加的学号在201215000与201215999之间，性别是男或女
            }
            finally
            {
                con.Dispose();//释放
            }
            this.studentTableAdapter.Fill(this.curricula_variable_systemDataSet3.Student);//Form10_Load里的那条代码
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql");//定义
            try
            {
                con.Open();
                string select_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是ID
                string delete_by_id = "delete from Student where Sno=" + select_id;//sql删除语句
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
            this.studentTableAdapter.Fill(this.curricula_variable_systemDataSet3.Student);//Form10_Load里的那条代码
        }

        private void buttonUpdate_Click(object sender, EventArgs e)//根据学号修改姓名
        {
            String StuID = textBox1.Text.Trim();
            String StuName = textBox2.Text.Trim();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql");//定义
            try
            {
                con.Open();
                string insertStr = "UPDATE Student SET Sname = '" + StuName + "' WHERE Sno = '" + StuID + "'";
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
            this.studentTableAdapter.Fill(this.curricula_variable_systemDataSet3.Student);//Form10_Load里的那条代码
        }

        private void buttonSelect_Click(object sender, EventArgs e)//根据学号查询
        {
            String StuID = textBox1.Text.Trim();
            String conn = "Data Source=.;Initial Catalog=curricula_variable_system;User ID=sa;Password=sql";
            SqlConnection sqlConnection = new SqlConnection(conn);  //实例化连接对象
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }
    }
}
