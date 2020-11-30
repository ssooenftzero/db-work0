namespace WindowsForms
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSchoolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdentityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.sysUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.curricula_variable_systemDataSet2 = new WindowsForms.curricula_variable_systemDataSet2();
            this.sysUserTableAdapter = new WindowsForms.curricula_variable_systemDataSet2TableAdapters.SysUserTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curricula_variable_systemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-18, -34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(924, 552);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userPassWordDataGridViewTextBoxColumn,
            this.userSchoolIDDataGridViewTextBoxColumn,
            this.userMobileDataGridViewTextBoxColumn,
            this.userBirthdayDataGridViewTextBoxColumn,
            this.userIdentityDataGridViewTextBoxColumn,
            this.userPhotoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.sysUserBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(864, 265);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userPassWordDataGridViewTextBoxColumn
            // 
            this.userPassWordDataGridViewTextBoxColumn.DataPropertyName = "UserPassWord";
            this.userPassWordDataGridViewTextBoxColumn.HeaderText = "UserPassWord";
            this.userPassWordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userPassWordDataGridViewTextBoxColumn.Name = "userPassWordDataGridViewTextBoxColumn";
            this.userPassWordDataGridViewTextBoxColumn.Width = 125;
            // 
            // userSchoolIDDataGridViewTextBoxColumn
            // 
            this.userSchoolIDDataGridViewTextBoxColumn.DataPropertyName = "UserSchoolID";
            this.userSchoolIDDataGridViewTextBoxColumn.HeaderText = "UserSchoolID";
            this.userSchoolIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userSchoolIDDataGridViewTextBoxColumn.Name = "userSchoolIDDataGridViewTextBoxColumn";
            this.userSchoolIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userMobileDataGridViewTextBoxColumn
            // 
            this.userMobileDataGridViewTextBoxColumn.DataPropertyName = "UserMobile";
            this.userMobileDataGridViewTextBoxColumn.HeaderText = "UserMobile";
            this.userMobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userMobileDataGridViewTextBoxColumn.Name = "userMobileDataGridViewTextBoxColumn";
            this.userMobileDataGridViewTextBoxColumn.Width = 125;
            // 
            // userBirthdayDataGridViewTextBoxColumn
            // 
            this.userBirthdayDataGridViewTextBoxColumn.DataPropertyName = "UserBirthday";
            this.userBirthdayDataGridViewTextBoxColumn.HeaderText = "UserBirthday";
            this.userBirthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userBirthdayDataGridViewTextBoxColumn.Name = "userBirthdayDataGridViewTextBoxColumn";
            this.userBirthdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdentityDataGridViewTextBoxColumn
            // 
            this.userIdentityDataGridViewTextBoxColumn.DataPropertyName = "UserIdentity";
            this.userIdentityDataGridViewTextBoxColumn.HeaderText = "UserIdentity";
            this.userIdentityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdentityDataGridViewTextBoxColumn.Name = "userIdentityDataGridViewTextBoxColumn";
            this.userIdentityDataGridViewTextBoxColumn.Width = 125;
            // 
            // userPhotoDataGridViewImageColumn
            // 
            this.userPhotoDataGridViewImageColumn.DataPropertyName = "UserPhoto";
            this.userPhotoDataGridViewImageColumn.HeaderText = "UserPhoto";
            this.userPhotoDataGridViewImageColumn.MinimumWidth = 6;
            this.userPhotoDataGridViewImageColumn.Name = "userPhotoDataGridViewImageColumn";
            this.userPhotoDataGridViewImageColumn.Width = 125;
            // 
            // sysUserBindingSource
            // 
            this.sysUserBindingSource.DataMember = "SysUser";
            this.sysUserBindingSource.DataSource = this.curricula_variable_systemDataSet2;
            // 
            // curricula_variable_systemDataSet2
            // 
            this.curricula_variable_systemDataSet2.DataSetName = "curricula_variable_systemDataSet2";
            this.curricula_variable_systemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sysUserTableAdapter
            // 
            this.sysUserTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(740, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(740, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(30, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(244, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "查看照片";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 25);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(233, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "UserSchoolID";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 509);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form8";
            this.Text = "登录记录页面";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curricula_variable_systemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private curricula_variable_systemDataSet2 curricula_variable_systemDataSet2;
        private System.Windows.Forms.BindingSource sysUserBindingSource;
        private curricula_variable_systemDataSet2TableAdapters.SysUserTableAdapter sysUserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSchoolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userBirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdentityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn userPhotoDataGridViewImageColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}