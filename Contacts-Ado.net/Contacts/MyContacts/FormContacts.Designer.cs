namespace MyContacts
{
    partial class FormContacts
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddContact = new System.Windows.Forms.ToolStripButton();
            this.btnEditContact = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteContact = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearchContacts = new System.Windows.Forms.ToolStripTextBox();
            this.btnRefreshContacts = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvContacts);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 314);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست مخاطبین";
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContacts.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FullName,
            this.Mobile,
            this.Email});
            this.dgvContacts.Location = new System.Drawing.Point(6, 21);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.Size = new System.Drawing.Size(548, 287);
            this.dgvContacts.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "ContactID";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddContact,
            this.btnEditContact,
            this.btnDeleteContact,
            this.toolStripLabel1,
            this.txtSearchContacts,
            this.btnRefreshContacts});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 96);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddContact
            // 
            this.btnAddContact.ForeColor = System.Drawing.Color.Black;
            this.btnAddContact.Image = global::MyContacts.Properties.Resources.addusergroup_1251;
            this.btnAddContact.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddContact.Size = new System.Drawing.Size(116, 93);
            this.btnAddContact.Text = "افزودن شخص جدید";
            this.btnAddContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnEditContact
            // 
            this.btnEditContact.ForeColor = System.Drawing.Color.Black;
            this.btnEditContact.Image = global::MyContacts.Properties.Resources.businessapplication_edit_male_user_thepencil_theclient_negocio_2321;
            this.btnEditContact.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditContact.Size = new System.Drawing.Size(93, 93);
            this.btnEditContact.Text = "ویرایش شخص";
            this.btnEditContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteContact.Image = global::MyContacts.Properties.Resources.iconfinder_trash_4341321_120557;
            this.btnDeleteContact.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Padding = new System.Windows.Forms.Padding(5);
            this.btnDeleteContact.Size = new System.Drawing.Size(82, 93);
            this.btnDeleteContact.Text = "حذف شخص";
            this.btnDeleteContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 93);
            this.toolStripLabel1.Text = "جستجو کنید : ";
            // 
            // txtSearchContacts
            // 
            this.txtSearchContacts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchContacts.Name = "txtSearchContacts";
            this.txtSearchContacts.Size = new System.Drawing.Size(100, 96);
            this.txtSearchContacts.TextChanged += new System.EventHandler(this.txtSearchContacts_TextChanged);
            // 
            // btnRefreshContacts
            // 
            this.btnRefreshContacts.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshContacts.Image = global::MyContacts.Properties.Resources.refresh_arrow_1546;
            this.btnRefreshContacts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefreshContacts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshContacts.Name = "btnRefreshContacts";
            this.btnRefreshContacts.Padding = new System.Windows.Forms.Padding(5);
            this.btnRefreshContacts.Size = new System.Drawing.Size(78, 93);
            this.btnRefreshContacts.Text = "بروزرسانی";
            this.btnRefreshContacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefreshContacts.Click += new System.EventHandler(this.btnRefreshContacts_Click);
            // 
            // FormContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormContacts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مخاطبین";
            this.Load += new System.EventHandler(this.FormContacts_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddContact;
        private System.Windows.Forms.ToolStripButton btnEditContact;
        private System.Windows.Forms.ToolStripButton btnDeleteContact;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSearchContacts;
        private System.Windows.Forms.ToolStripButton btnRefreshContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

