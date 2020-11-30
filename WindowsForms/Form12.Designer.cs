namespace WindowsForms
{
    partial class Form12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.curricula_variable_systemDataSet7 = new WindowsForms.curricula_variable_systemDataSet7();
            this.sCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.curricula_variable_systemDataSet6 = new WindowsForms.curricula_variable_systemDataSet6();
            this.sCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.curricula_variable_systemDataSet5 = new WindowsForms.curricula_variable_systemDataSet5();
            this.sCTableAdapter = new WindowsForms.curricula_variable_systemDataSet5TableAdapters.SCTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.sCTableAdapter1 = new WindowsForms.curricula_variable_systemDataSet6TableAdapters.SCTableAdapter();
            this.sCTableAdapter2 = new WindowsForms.curricula_variable_systemDataSet7TableAdapters.SCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curricula_variable_systemDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curricula_variable_systemDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curricula_variable_systemDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-22, -48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 552);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.cnoDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sCBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(455, 325);
            this.dataGridView1.TabIndex = 1;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.snoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cnoDataGridViewTextBoxColumn
            // 
            this.cnoDataGridViewTextBoxColumn.DataPropertyName = "Cno";
            this.cnoDataGridViewTextBoxColumn.HeaderText = "Cno";
            this.cnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnoDataGridViewTextBoxColumn.Name = "cnoDataGridViewTextBoxColumn";
            this.cnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sCBindingSource2
            // 
            this.sCBindingSource2.DataMember = "SC";
            this.sCBindingSource2.DataSource = this.curricula_variable_systemDataSet7;
            // 
            // curricula_variable_systemDataSet7
            // 
            this.curricula_variable_systemDataSet7.DataSetName = "curricula_variable_systemDataSet7";
            this.curricula_variable_systemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCBindingSource1
            // 
            this.sCBindingSource1.DataMember = "SC";
            this.sCBindingSource1.DataSource = this.curricula_variable_systemDataSet6;
            // 
            // curricula_variable_systemDataSet6
            // 
            this.curricula_variable_systemDataSet6.DataSetName = "curricula_variable_systemDataSet6";
            this.curricula_variable_systemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCBindingSource
            // 
            this.sCBindingSource.DataMember = "SC";
            this.sCBindingSource.DataSource = this.curricula_variable_systemDataSet5;
            // 
            // curricula_variable_systemDataSet5
            // 
            this.curricula_variable_systemDataSet5.DataSetName = "curricula_variable_systemDataSet5";
            this.curricula_variable_systemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCTableAdapter
            // 
            this.sCTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(507, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "学号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 25);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(507, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "课程号";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(603, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 25);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(534, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(686, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(686, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 49);
            this.button4.TabIndex = 10;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(512, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "成绩";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(607, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 25);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(534, 391);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 47);
            this.button5.TabIndex = 13;
            this.button5.Text = "返回";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(686, 391);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 47);
            this.button6.TabIndex = 14;
            this.button6.Text = "退出";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(600, 163);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 39);
            this.button7.TabIndex = 15;
            this.button7.Text = "清空行";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // sCTableAdapter1
            // 
            this.sCTableAdapter1.ClearBeforeFill = true;
            // 
            // sCTableAdapter2
            // 
            this.sCTableAdapter2.ClearBeforeFill = true;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form12";
            this.Text = "SC表";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curricula_variable_systemDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curricula_variable_systemDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curricula_variable_systemDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private curricula_variable_systemDataSet5 curricula_variable_systemDataSet5;
        private System.Windows.Forms.BindingSource sCBindingSource;
        private curricula_variable_systemDataSet5TableAdapters.SCTableAdapter sCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private curricula_variable_systemDataSet6 curricula_variable_systemDataSet6;
        private System.Windows.Forms.BindingSource sCBindingSource1;
        private curricula_variable_systemDataSet6TableAdapters.SCTableAdapter sCTableAdapter1;
        private curricula_variable_systemDataSet7 curricula_variable_systemDataSet7;
        private System.Windows.Forms.BindingSource sCBindingSource2;
        private curricula_variable_systemDataSet7TableAdapters.SCTableAdapter sCTableAdapter2;
    }
}