namespace SAD
{
    partial class CreateTemplate
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReceiver = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtsenttime = new System.Windows.Forms.DateTimePicker();
            this.btnCreateTemp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoToTask = new System.Windows.Forms.RadioButton();
            this.YesToTask = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NoToAutomatic = new System.Windows.Forms.RadioButton();
            this.YesToAutomatic = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NoToReminder = new System.Windows.Forms.RadioButton();
            this.YesToReminder = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Priority = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(390, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "عنوان:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 52);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "متن نامه:";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(80, 52);
            this.txtText.Name = "txtText";
            this.txtText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtText.Size = new System.Drawing.Size(410, 121);
            this.txtText.TabIndex = 1;
            this.txtText.Text = "";
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 204);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "گروه دریافت کننده:";
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(80, 204);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReceiver.Size = new System.Drawing.Size(410, 62);
            this.txtReceiver.TabIndex = 2;
            this.txtReceiver.Text = "Type each receiver in a single line.";
            this.txtReceiver.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 292);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ایجاد کار؟";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 331);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "زمان ارسال:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtsenttime
            // 
            this.dtsenttime.Location = new System.Drawing.Point(51, 331);
            this.dtsenttime.Name = "dtsenttime";
            this.dtsenttime.Size = new System.Drawing.Size(200, 20);
            this.dtsenttime.TabIndex = 7;
            // 
            // btnCreateTemp
            // 
            this.btnCreateTemp.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCreateTemp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateTemp.Location = new System.Drawing.Point(80, 434);
            this.btnCreateTemp.Name = "btnCreateTemp";
            this.btnCreateTemp.Size = new System.Drawing.Size(102, 40);
            this.btnCreateTemp.TabIndex = 8;
            this.btnCreateTemp.Text = "ایجاد قالب جدید";
            this.btnCreateTemp.UseVisualStyleBackColor = false;
            this.btnCreateTemp.Click += new System.EventHandler(this.btnCreateTemp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 331);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ارسال خودکار؟";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoToTask);
            this.groupBox1.Controls.Add(this.YesToTask);
            this.groupBox1.Location = new System.Drawing.Point(399, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(200, 37);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // NoToTask
            // 
            this.NoToTask.AutoSize = true;
            this.NoToTask.Location = new System.Drawing.Point(121, 18);
            this.NoToTask.Name = "NoToTask";
            this.NoToTask.Size = new System.Drawing.Size(41, 17);
            this.NoToTask.TabIndex = 1;
            this.NoToTask.TabStop = true;
            this.NoToTask.Text = "خیر";
            this.NoToTask.UseVisualStyleBackColor = true;
            // 
            // YesToTask
            // 
            this.YesToTask.AutoSize = true;
            this.YesToTask.Location = new System.Drawing.Point(9, 16);
            this.YesToTask.Name = "YesToTask";
            this.YesToTask.Size = new System.Drawing.Size(37, 17);
            this.YesToTask.TabIndex = 0;
            this.YesToTask.TabStop = true;
            this.YesToTask.Text = "بله";
            this.YesToTask.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoToAutomatic);
            this.groupBox2.Controls.Add(this.YesToAutomatic);
            this.groupBox2.Location = new System.Drawing.Point(399, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(200, 37);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // NoToAutomatic
            // 
            this.NoToAutomatic.AutoSize = true;
            this.NoToAutomatic.Location = new System.Drawing.Point(122, 13);
            this.NoToAutomatic.Name = "NoToAutomatic";
            this.NoToAutomatic.Size = new System.Drawing.Size(41, 17);
            this.NoToAutomatic.TabIndex = 1;
            this.NoToAutomatic.TabStop = true;
            this.NoToAutomatic.Text = "خیر";
            this.NoToAutomatic.UseVisualStyleBackColor = true;
            // 
            // YesToAutomatic
            // 
            this.YesToAutomatic.AutoSize = true;
            this.YesToAutomatic.Location = new System.Drawing.Point(9, 13);
            this.YesToAutomatic.Name = "YesToAutomatic";
            this.YesToAutomatic.Size = new System.Drawing.Size(37, 17);
            this.YesToAutomatic.TabIndex = 0;
            this.YesToAutomatic.TabStop = true;
            this.YesToAutomatic.Text = "بله";
            this.YesToAutomatic.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NoToReminder);
            this.groupBox3.Controls.Add(this.YesToReminder);
            this.groupBox3.Location = new System.Drawing.Point(399, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(200, 37);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // NoToReminder
            // 
            this.NoToReminder.AutoSize = true;
            this.NoToReminder.Location = new System.Drawing.Point(122, 16);
            this.NoToReminder.Name = "NoToReminder";
            this.NoToReminder.Size = new System.Drawing.Size(41, 17);
            this.NoToReminder.TabIndex = 1;
            this.NoToReminder.TabStop = true;
            this.NoToReminder.Text = "خیر";
            this.NoToReminder.UseVisualStyleBackColor = true;
            // 
            // YesToReminder
            // 
            this.YesToReminder.AutoSize = true;
            this.YesToReminder.Location = new System.Drawing.Point(8, 16);
            this.YesToReminder.Name = "YesToReminder";
            this.YesToReminder.Size = new System.Drawing.Size(37, 17);
            this.YesToReminder.TabIndex = 0;
            this.YesToReminder.TabStop = true;
            this.YesToReminder.Text = "بله";
            this.YesToReminder.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "تعریف یادآور؟";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 295);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "اولویت نامه:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Priority
            // 
            this.Priority.FormattingEnabled = true;
            this.Priority.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Priority.Location = new System.Drawing.Point(151, 290);
            this.Priority.Margin = new System.Windows.Forms.Padding(2);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(92, 21);
            this.Priority.TabIndex = 6;
            this.Priority.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 486);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreateTemp);
            this.Controls.Add(this.dtsenttime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReceiver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Name = "CreateTemplate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CreateTemplate";
            this.Load += new System.EventHandler(this.CreateTemplate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtReceiver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtsenttime;
        private System.Windows.Forms.Button btnCreateTemp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NoToTask;
        private System.Windows.Forms.RadioButton YesToTask;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton NoToAutomatic;
        private System.Windows.Forms.RadioButton YesToAutomatic;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton NoToReminder;
        private System.Windows.Forms.RadioButton YesToReminder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Priority;
    }
}