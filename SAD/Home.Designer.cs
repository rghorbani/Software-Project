namespace SAD
{
    partial class Home
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
            this.btnCreateTemplate = new System.Windows.Forms.Button();
            this.btnShowTemps = new System.Windows.Forms.Button();
            this.btnAddReciever = new System.Windows.Forms.Button();
            this.btnMakeGroup = new System.Windows.Forms.Button();
            this.btnShowGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTemplate
            // 
            this.btnCreateTemplate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateTemplate.Location = new System.Drawing.Point(445, 53);
            this.btnCreateTemplate.Name = "btnCreateTemplate";
            this.btnCreateTemplate.Size = new System.Drawing.Size(93, 67);
            this.btnCreateTemplate.TabIndex = 0;
            this.btnCreateTemplate.Text = "ایجاد قالب جدید ";
            this.btnCreateTemplate.UseVisualStyleBackColor = false;
            this.btnCreateTemplate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowTemps
            // 
            this.btnShowTemps.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShowTemps.Location = new System.Drawing.Point(302, 53);
            this.btnShowTemps.Name = "btnShowTemps";
            this.btnShowTemps.Size = new System.Drawing.Size(93, 67);
            this.btnShowTemps.TabIndex = 1;
            this.btnShowTemps.Text = "مشاهده قالب های موجود";
            this.btnShowTemps.UseVisualStyleBackColor = false;
            this.btnShowTemps.Click += new System.EventHandler(this.btnShowTemps_Click);
            // 
            // btnAddReciever
            // 
            this.btnAddReciever.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddReciever.Location = new System.Drawing.Point(445, 154);
            this.btnAddReciever.Name = "btnAddReciever";
            this.btnAddReciever.Size = new System.Drawing.Size(93, 67);
            this.btnAddReciever.TabIndex = 2;
            this.btnAddReciever.Text = "اضافه کردن مخاطب جدید";
            this.btnAddReciever.UseVisualStyleBackColor = false;
            this.btnAddReciever.Click += new System.EventHandler(this.btnAddReciever_Click);
            // 
            // btnMakeGroup
            // 
            this.btnMakeGroup.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMakeGroup.Location = new System.Drawing.Point(302, 154);
            this.btnMakeGroup.Name = "btnMakeGroup";
            this.btnMakeGroup.Size = new System.Drawing.Size(93, 67);
            this.btnMakeGroup.TabIndex = 3;
            this.btnMakeGroup.Text = "اضافه کردن گروه جدید";
            this.btnMakeGroup.UseVisualStyleBackColor = false;
            this.btnMakeGroup.Click += new System.EventHandler(this.btnMakeGroup_Click);
            // 
            // btnShowGroup
            // 
            this.btnShowGroup.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowGroup.Location = new System.Drawing.Point(158, 154);
            this.btnShowGroup.Name = "btnShowGroup";
            this.btnShowGroup.Size = new System.Drawing.Size(93, 67);
            this.btnShowGroup.TabIndex = 4;
            this.btnShowGroup.Text = "مشاهده گروه ها";
            this.btnShowGroup.UseVisualStyleBackColor = false;
            this.btnShowGroup.Click += new System.EventHandler(this.btnShowGroup_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 328);
            this.Controls.Add(this.btnShowGroup);
            this.Controls.Add(this.btnMakeGroup);
            this.Controls.Add(this.btnAddReciever);
            this.Controls.Add(this.btnShowTemps);
            this.Controls.Add(this.btnCreateTemplate);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTemplate;
        private System.Windows.Forms.Button btnShowTemps;
        private System.Windows.Forms.Button btnAddReciever;
        private System.Windows.Forms.Button btnMakeGroup;
        private System.Windows.Forms.Button btnShowGroup;
    }
}