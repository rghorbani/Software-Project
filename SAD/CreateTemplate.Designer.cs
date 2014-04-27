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
            this.label5 = new System.Windows.Forms.Label();
            this.dtsenttime = new System.Windows.Forms.DateTimePicker();
            this.btnCreateTemp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.YesToAutomatic = new System.Windows.Forms.RadioButton();
            this.NoToAutomatic = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoToPeriodic = new System.Windows.Forms.RadioButton();
            this.YesToPeriodic = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.year = new System.Windows.Forms.RadioButton();
            this.month1 = new System.Windows.Forms.RadioButton();
            this.month3 = new System.Windows.Forms.RadioButton();
            this.month6 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupsDropDown = new System.Windows.Forms.ComboBox();
            this.ReceiversDropDown = new System.Windows.Forms.ComboBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 490);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "زمان ارسال:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtsenttime
            // 
            this.dtsenttime.Location = new System.Drawing.Point(27, 485);
            this.dtsenttime.Name = "dtsenttime";
            this.dtsenttime.Size = new System.Drawing.Size(200, 20);
            this.dtsenttime.TabIndex = 6;
            this.dtsenttime.ValueChanged += new System.EventHandler(this.dtsenttime_ValueChanged);
            // 
            // btnCreateTemp
            // 
            this.btnCreateTemp.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCreateTemp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateTemp.Location = new System.Drawing.Point(80, 534);
            this.btnCreateTemp.Name = "btnCreateTemp";
            this.btnCreateTemp.Size = new System.Drawing.Size(102, 40);
            this.btnCreateTemp.TabIndex = 7;
            this.btnCreateTemp.Text = "ایجاد قالب جدید";
            this.btnCreateTemp.UseVisualStyleBackColor = false;
            this.btnCreateTemp.Click += new System.EventHandler(this.btnCreateTemp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 413);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "نوع دوره:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 449);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ارسال خودکار؟";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.YesToAutomatic.CheckedChanged += new System.EventHandler(this.YesToAutomatic_CheckedChanged);
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
            this.NoToAutomatic.CheckedChanged += new System.EventHandler(this.NoToAutomatic_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoToAutomatic);
            this.groupBox2.Controls.Add(this.YesToAutomatic);
            this.groupBox2.Location = new System.Drawing.Point(375, 436);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(200, 37);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoToPeriodic);
            this.groupBox1.Controls.Add(this.YesToPeriodic);
            this.groupBox1.Location = new System.Drawing.Point(375, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(200, 37);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NoToPeriodic
            // 
            this.NoToPeriodic.AutoSize = true;
            this.NoToPeriodic.Location = new System.Drawing.Point(121, 18);
            this.NoToPeriodic.Name = "NoToPeriodic";
            this.NoToPeriodic.Size = new System.Drawing.Size(41, 17);
            this.NoToPeriodic.TabIndex = 1;
            this.NoToPeriodic.TabStop = true;
            this.NoToPeriodic.Text = "خیر";
            this.NoToPeriodic.UseVisualStyleBackColor = true;
            this.NoToPeriodic.CheckedChanged += new System.EventHandler(this.NoToPeriodic_CheckedChanged);
            // 
            // YesToPeriodic
            // 
            this.YesToPeriodic.AutoSize = true;
            this.YesToPeriodic.Location = new System.Drawing.Point(9, 16);
            this.YesToPeriodic.Name = "YesToPeriodic";
            this.YesToPeriodic.Size = new System.Drawing.Size(37, 17);
            this.YesToPeriodic.TabIndex = 0;
            this.YesToPeriodic.TabStop = true;
            this.YesToPeriodic.Text = "بله";
            this.YesToPeriodic.UseVisualStyleBackColor = true;
            this.YesToPeriodic.CheckedChanged += new System.EventHandler(this.YesToPeriodic_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 410);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ارسال دوره ای؟";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.year);
            this.groupBox3.Controls.Add(this.month1);
            this.groupBox3.Controls.Add(this.month3);
            this.groupBox3.Controls.Add(this.month6);
            this.groupBox3.Location = new System.Drawing.Point(44, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(200, 70);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter_1);
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(41, 40);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(60, 17);
            this.year.TabIndex = 3;
            this.year.TabStop = true;
            this.year.Text = "یک ساله";
            this.year.UseVisualStyleBackColor = true;
            this.year.CheckedChanged += new System.EventHandler(this.year_CheckedChanged);
            // 
            // month1
            // 
            this.month1.AutoSize = true;
            this.month1.Location = new System.Drawing.Point(133, 41);
            this.month1.Name = "month1";
            this.month1.Size = new System.Drawing.Size(60, 17);
            this.month1.TabIndex = 2;
            this.month1.TabStop = true;
            this.month1.Text = "یک ماهه";
            this.month1.UseVisualStyleBackColor = true;
            this.month1.CheckedChanged += new System.EventHandler(this.month1_CheckedChanged);
            // 
            // month3
            // 
            this.month3.AutoSize = true;
            this.month3.Location = new System.Drawing.Point(128, 18);
            this.month3.Name = "month3";
            this.month3.Size = new System.Drawing.Size(63, 17);
            this.month3.TabIndex = 1;
            this.month3.TabStop = true;
            this.month3.Text = "سه ماهه";
            this.month3.UseVisualStyleBackColor = true;
            this.month3.CheckedChanged += new System.EventHandler(this.month3_CheckedChanged);
            // 
            // month6
            // 
            this.month6.AutoSize = true;
            this.month6.Location = new System.Drawing.Point(34, 16);
            this.month6.Name = "month6";
            this.month6.Size = new System.Drawing.Size(67, 17);
            this.month6.TabIndex = 0;
            this.month6.TabStop = true;
            this.month6.Text = "شش ماهه";
            this.month6.UseVisualStyleBackColor = true;
            this.month6.CheckedChanged += new System.EventHandler(this.month6_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 192);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = ":دریافت‌کنندگان";
            // 
            // GroupsDropDown
            // 
            this.GroupsDropDown.FormattingEnabled = true;
            this.GroupsDropDown.Location = new System.Drawing.Point(369, 189);
            this.GroupsDropDown.Name = "GroupsDropDown";
            this.GroupsDropDown.Size = new System.Drawing.Size(121, 21);
            this.GroupsDropDown.TabIndex = 22;
            this.GroupsDropDown.SelectedIndexChanged += new System.EventHandler(this.GroupsDropDown_SelectedIndexChanged);
            // 
            // ReceiversDropDown
            // 
            this.ReceiversDropDown.FormattingEnabled = true;
            this.ReceiversDropDown.Location = new System.Drawing.Point(178, 192);
            this.ReceiversDropDown.Name = "ReceiversDropDown";
            this.ReceiversDropDown.Size = new System.Drawing.Size(121, 21);
            this.ReceiversDropDown.TabIndex = 23;
            this.ReceiversDropDown.SelectedIndexChanged += new System.EventHandler(this.ReceiversDropDown_SelectedIndexChanged);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(390, 226);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(97, 21);
            this.btnAddGroup.TabIndex = 24;
            this.btnAddGroup.Text = "اضافه کردن گروه";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(369, 273);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 26;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(179, 273);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 21);
            this.button1.TabIndex = 28;
            this.button1.Text = "اضافه کردن عضو ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.ReceiversDropDown);
            this.Controls.Add(this.GroupsDropDown);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreateTemp);
            this.Controls.Add(this.dtsenttime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Name = "CreateTemplate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CreateTemplate";
            this.Load += new System.EventHandler(this.CreateTemplate_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtsenttime;
        private System.Windows.Forms.Button btnCreateTemp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton YesToAutomatic;
        private System.Windows.Forms.RadioButton NoToAutomatic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NoToPeriodic;
        private System.Windows.Forms.RadioButton YesToPeriodic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton month3;
        private System.Windows.Forms.RadioButton month6;
        private System.Windows.Forms.RadioButton year;
        private System.Windows.Forms.RadioButton month1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GroupsDropDown;
        private System.Windows.Forms.ComboBox ReceiversDropDown;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
    }
}