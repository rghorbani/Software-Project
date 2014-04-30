namespace SAD
{
    partial class MakeGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMakeGroup = new System.Windows.Forms.Button();
            this.root_group = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "نام گروه:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(65, 54);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(132, 22);
            this.txtTitle.TabIndex = 9;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(16, 100);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(181, 105);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Text = "";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "توضیحات:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnMakeGroup
            // 
            this.btnMakeGroup.Location = new System.Drawing.Point(16, 258);
            this.btnMakeGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakeGroup.Name = "btnMakeGroup";
            this.btnMakeGroup.Size = new System.Drawing.Size(100, 28);
            this.btnMakeGroup.TabIndex = 15;
            this.btnMakeGroup.Text = "ثبت گروه";
            this.btnMakeGroup.UseVisualStyleBackColor = true;
            this.btnMakeGroup.Click += new System.EventHandler(this.btnMakeGroup_Click);
            // 
            // root_group
            // 
            this.root_group.FormattingEnabled = true;
            this.root_group.Location = new System.Drawing.Point(16, 212);
            this.root_group.Name = "root_group";
            this.root_group.Size = new System.Drawing.Size(181, 24);
            this.root_group.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "پدر:";
            // 
            // MakeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.root_group);
            this.Controls.Add(this.btnMakeGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MakeGroup";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MakeGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMakeGroup;
        private System.Windows.Forms.ComboBox root_group;
        private System.Windows.Forms.Label label3;
    }
}