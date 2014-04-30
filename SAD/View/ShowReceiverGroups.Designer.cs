namespace SAD
{
    partial class ShowReceiverGroups
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
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.description = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Receivers = new System.Windows.Forms.DataGridViewButtonColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMakeGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description,
            this.Receivers,
            this.title});
            this.dataGridViewGroups.Location = new System.Drawing.Point(138, 1);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.Size = new System.Drawing.Size(345, 246);
            this.dataGridViewGroups.TabIndex = 0;
            this.dataGridViewGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroups_CellContentClick);
            // 
            // description
            // 
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            this.description.Text = "نمایش";
            // 
            // Receivers
            // 
            this.Receivers.HeaderText = "دریافت کنندگان";
            this.Receivers.Name = "Receivers";
            // 
            // title
            // 
            this.title.HeaderText = "عنوان";
            this.title.Name = "title";
            // 
            // btnMakeGroup
            // 
            this.btnMakeGroup.Location = new System.Drawing.Point(21, 23);
            this.btnMakeGroup.Name = "btnMakeGroup";
            this.btnMakeGroup.Size = new System.Drawing.Size(97, 42);
            this.btnMakeGroup.TabIndex = 1;
            this.btnMakeGroup.Text = "ایجاد گروه جدید";
            this.btnMakeGroup.UseVisualStyleBackColor = true;
            this.btnMakeGroup.Click += new System.EventHandler(this.btnMakeGroup_Click);
            // 
            // ShowReceiverGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 330);
            this.Controls.Add(this.btnMakeGroup);
            this.Controls.Add(this.dataGridViewGroups);
            this.Name = "ShowReceiverGroups";
            this.Text = "ShowReceiverGroups";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.DataGridViewButtonColumn description;
        private System.Windows.Forms.DataGridViewButtonColumn Receivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.Button btnMakeGroup;
    }
}