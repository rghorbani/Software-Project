namespace SAD
{
    partial class AddReciever
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.optionRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddReciever = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(57, 16);
            this.txtFName.Name = "txtFName";
            this.txtFName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(57, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // optionRole
            // 
            this.optionRole.FormattingEnabled = true;
            this.optionRole.Items.AddRange(new object[] {
            "استاد",
            "دانشجو"});
            this.optionRole.Location = new System.Drawing.Point(57, 141);
            this.optionRole.Margin = new System.Windows.Forms.Padding(2);
            this.optionRole.Name = "optionRole";
            this.optionRole.Size = new System.Drawing.Size(92, 21);
            this.optionRole.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "نام :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 104);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "پست الکترونیک:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 149);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "نقش مخاطب:";
            // 
            // btnAddReciever
            // 
            this.btnAddReciever.Location = new System.Drawing.Point(57, 202);
            this.btnAddReciever.Name = "btnAddReciever";
            this.btnAddReciever.Size = new System.Drawing.Size(75, 23);
            this.btnAddReciever.TabIndex = 5;
            this.btnAddReciever.Text = "ثبت کاربر";
            this.btnAddReciever.UseVisualStyleBackColor = true;
            this.btnAddReciever.Click += new System.EventHandler(this.btnAddReciever_Click);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(57, 55);
            this.txtLName.Name = "txtLName";
            this.txtLName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 62);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "نام خانوادگی:";
            // 
            // AddReciever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.btnAddReciever);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionRole);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFName);
            this.Name = "AddReciever";
            this.Text = "AddReciever";
            this.Load += new System.EventHandler(this.AddReciever_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox optionRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddReciever;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label4;
    }
}