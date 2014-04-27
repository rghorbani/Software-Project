namespace SAD
{
    partial class AddReceiversToGroup
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
            this.ReceiversDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReceiversDropDown
            // 
            this.ReceiversDropDown.FormattingEnabled = true;
            this.ReceiversDropDown.Location = new System.Drawing.Point(31, 91);
            this.ReceiversDropDown.Name = "ReceiversDropDown";
            this.ReceiversDropDown.Size = new System.Drawing.Size(121, 21);
            this.ReceiversDropDown.TabIndex = 0;
            this.ReceiversDropDown.SelectedIndexChanged += new System.EventHandler(this.ReceiversDropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = ":دریافت‌کنندگان";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "افزودن به گروه";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddReceiversToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReceiversDropDown);
            this.Name = "AddReceiversToGroup";
            this.Text = "AddReceiversToGroup";
            this.Load += new System.EventHandler(this.AddReceiversToGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ReceiversDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}