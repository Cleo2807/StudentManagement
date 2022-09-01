namespace StudentManagement
{
    partial class Form5
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
            this.Replacebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSID = new System.Windows.Forms.TextBox();
            this.tbSN = new System.Windows.Forms.TextBox();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.tbMN = new System.Windows.Forms.TextBox();
            this.tbCL = new System.Windows.Forms.TextBox();
            this.tbCty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Replacebtn
            // 
            this.Replacebtn.AccessibleName = "";
            this.Replacebtn.Location = new System.Drawing.Point(594, 136);
            this.Replacebtn.Name = "Replacebtn";
            this.Replacebtn.Size = new System.Drawing.Size(105, 72);
            this.Replacebtn.TabIndex = 0;
            this.Replacebtn.Text = "REPLACE";
            this.Replacebtn.UseVisualStyleBackColor = true;
            this.Replacebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "StudentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Faher Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mothers Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "City";
            // 
            // tbSID
            // 
            this.tbSID.AccessibleName = "TBID";
            this.tbSID.Location = new System.Drawing.Point(247, 51);
            this.tbSID.Name = "tbSID";
            this.tbSID.Size = new System.Drawing.Size(100, 26);
            this.tbSID.TabIndex = 2;
            // 
            // tbSN
            // 
            this.tbSN.AccessibleName = "TBNAME";
            this.tbSN.Location = new System.Drawing.Point(247, 90);
            this.tbSN.Name = "tbSN";
            this.tbSN.Size = new System.Drawing.Size(100, 26);
            this.tbSN.TabIndex = 2;
            // 
            // tbFN
            // 
            this.tbFN.AccessibleName = "TBFN";
            this.tbFN.Location = new System.Drawing.Point(247, 133);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(100, 26);
            this.tbFN.TabIndex = 2;
            // 
            // tbMN
            // 
            this.tbMN.AccessibleName = "TBMN";
            this.tbMN.Location = new System.Drawing.Point(247, 188);
            this.tbMN.Name = "tbMN";
            this.tbMN.Size = new System.Drawing.Size(100, 26);
            this.tbMN.TabIndex = 2;
            // 
            // tbCL
            // 
            this.tbCL.AccessibleName = "TBCLASS";
            this.tbCL.Location = new System.Drawing.Point(247, 234);
            this.tbCL.Name = "tbCL";
            this.tbCL.Size = new System.Drawing.Size(100, 26);
            this.tbCL.TabIndex = 2;
            // 
            // tbCty
            // 
            this.tbCty.AccessibleName = "TBCITY";
            this.tbCty.Location = new System.Drawing.Point(247, 284);
            this.tbCty.Name = "tbCty";
            this.tbCty.Size = new System.Drawing.Size(100, 26);
            this.tbCty.TabIndex = 2;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCty);
            this.Controls.Add(this.tbCL);
            this.Controls.Add(this.tbMN);
            this.Controls.Add(this.tbFN);
            this.Controls.Add(this.tbSN);
            this.Controls.Add(this.tbSID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Replacebtn);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Replacebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSID;
        private System.Windows.Forms.TextBox tbSN;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.TextBox tbMN;
        private System.Windows.Forms.TextBox tbCL;
        private System.Windows.Forms.TextBox tbCty;
    }
}