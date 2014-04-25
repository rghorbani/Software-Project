namespace SAD
{
    partial class ShowTemplates
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
            this.templateGridView = new System.Windows.Forms.DataGridView();
            this.addTemplate = new System.Windows.Forms.Button();
            this.templateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.templateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // templateGridView
            // 
            this.templateGridView.AllowUserToAddRows = false;
            this.templateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.templateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.templateGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.templateGridView.Location = new System.Drawing.Point(113, 0);
            this.templateGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.templateGridView.Name = "templateGridView";
            this.templateGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.templateGridView.RowTemplate.Height = 24;
            this.templateGridView.Size = new System.Drawing.Size(780, 483);
            this.templateGridView.TabIndex = 0;
            this.templateGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.templateGridView_CellContentClick);
            // 
            // addTemplate
            // 
            this.addTemplate.Location = new System.Drawing.Point(9, 28);
            this.addTemplate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addTemplate.Name = "addTemplate";
            this.addTemplate.Size = new System.Drawing.Size(100, 37);
            this.addTemplate.TabIndex = 1;
            this.addTemplate.Text = "ایجاد قالب نامه";
            this.addTemplate.UseVisualStyleBackColor = true;
            this.addTemplate.Click += new System.EventHandler(this.addTemplate_Click);
            // 
            // templateBindingSource
            // 
            this.templateBindingSource.DataSource = typeof(SAD.Template);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "عنوان";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "متن";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "گیرندگان";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "اولویت";
            this.Column5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "یادآورنده";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ارسال خودکار";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ایجاد کار";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "تاریخ ارسال";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ثبت تغییرات";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ShowTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 483);
            this.Controls.Add(this.addTemplate);
            this.Controls.Add(this.templateGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShowTemplates";
            this.Text = "ShowTemplates";
            this.Load += new System.EventHandler(this.ShowTemplates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.templateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView templateGridView;
        private System.Windows.Forms.Button addTemplate;
        private System.Windows.Forms.BindingSource templateBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
    }
}