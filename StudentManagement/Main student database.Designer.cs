
namespace StudentManagement
{
    partial class SMSFORM
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_dbDataSet2 = new StudentManagement.student_dbDataSet2();
            this.studentTableAdapter = new StudentManagement.student_dbDataSet2TableAdapters.StudentTableAdapter();
            this.GridStudentData = new System.Windows.Forms.DataGridView();
            this.studentdbDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "CREATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(963, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "UPDATE/ DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonUPDATEDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(355, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "STUDENT MANAGEMENT SYSTEM";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.student_dbDataSet2;
            // 
            // student_dbDataSet2
            // 
            this.student_dbDataSet2.DataSetName = "student_dbDataSet2";
            this.student_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // GridStudentData
            // 
            this.GridStudentData.AllowUserToAddRows = false;
            this.GridStudentData.AllowUserToDeleteRows = false;
            this.GridStudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStudentData.Location = new System.Drawing.Point(164, 222);
            this.GridStudentData.MultiSelect = false;
            this.GridStudentData.Name = "GridStudentData";
            this.GridStudentData.ReadOnly = true;
            this.GridStudentData.RowHeadersWidth = 62;
            this.GridStudentData.RowTemplate.Height = 28;
            this.GridStudentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridStudentData.Size = new System.Drawing.Size(964, 388);
            this.GridStudentData.TabIndex = 5;
            // 
            // studentdbDataSet2BindingSource
            // 
            this.studentdbDataSet2BindingSource.DataSource = this.student_dbDataSet2;
            this.studentdbDataSet2BindingSource.Position = 0;
            // 
            // SMSFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 653);
            this.Controls.Add(this.GridStudentData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SMSFORM";
            this.Text = "STUDENT MANAGEMENT SYSTEM";
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private student_dbDataSet2 student_dbDataSet2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private student_dbDataSet2TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView GridStudentData;
        private System.Windows.Forms.BindingSource studentdbDataSet2BindingSource;
    }
}

