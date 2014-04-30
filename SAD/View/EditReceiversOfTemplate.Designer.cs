namespace SAD
{
    partial class EditReceiversOfTemplate
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
            this.GroupsDropDown = new System.Windows.Forms.ComboBox();
            this.ReceiversDropDown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GroupsDropDown
            // 
            this.GroupsDropDown.FormattingEnabled = true;
            this.GroupsDropDown.Location = new System.Drawing.Point(195, 41);
            this.GroupsDropDown.Name = "GroupsDropDown";
            this.GroupsDropDown.Size = new System.Drawing.Size(121, 21);
            this.GroupsDropDown.TabIndex = 23;
            this.GroupsDropDown.SelectedIndexChanged += new System.EventHandler(this.GroupsDropDown_SelectedIndexChanged);
            // 
            // ReceiversDropDown
            // 
            this.ReceiversDropDown.FormattingEnabled = true;
            this.ReceiversDropDown.Location = new System.Drawing.Point(41, 41);
            this.ReceiversDropDown.Name = "ReceiversDropDown";
            this.ReceiversDropDown.Size = new System.Drawing.Size(121, 21);
            this.ReceiversDropDown.TabIndex = 24;
            this.ReceiversDropDown.SelectedIndexChanged += new System.EventHandler(this.ReceiversDropDown_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 49);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "دریافت کنندگان:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(218, 85);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(97, 21);
            this.btnAddGroup.TabIndex = 26;
            this.btnAddGroup.Text = "اضافه کردن گروه";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 21);
            this.button1.TabIndex = 29;
            this.button1.Text = "اضافه کردن عضو ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(207, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 30;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(42, 139);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(41, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 35);
            this.button2.TabIndex = 32;
            this.button2.Text = "اعمال تغییرات";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditReceiversOfTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 299);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReceiversDropDown);
            this.Controls.Add(this.GroupsDropDown);
            this.Name = "EditReceiversOfTemplate";
            this.Text = "EditReceiversOfTemplate";
            this.Load += new System.EventHandler(this.EditReceiversOfTemplate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GroupsDropDown;
        private System.Windows.Forms.ComboBox ReceiversDropDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
    }
}