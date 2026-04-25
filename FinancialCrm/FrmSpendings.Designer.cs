namespace FinancialCrm
{
    partial class FrmSpendings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.txtSpendingId = new System.Windows.Forms.TextBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterByCategory = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.dtpSpendingDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtSpendingAmount = new System.Windows.Forms.TextBox();
            this.txtSpendingTitle = new System.Windows.Forms.TextBox();
            this.lblSpendingDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSpendingAmount = new System.Windows.Forms.Label();
            this.lblSpendingTitle = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.panelHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(32, 25, 52);
            this.panelHeader.Controls.Add(this.btnMainMenu);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1280, 85);
            this.panelHeader.TabIndex = 0;

            // btnMainMenu
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(106, 48, 147);
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(1110, 22);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(140, 42);
            this.btnMainMenu.TabIndex = 12;
            this.btnMainMenu.Text = "🏠 Ana Menü";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(35, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(330, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "💳 Harcama Yönetimi";

            // panelLeft
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(38, 38, 46);
            this.panelLeft.Controls.Add(this.txtSpendingId);
            this.panelLeft.Controls.Add(this.btnToday);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.btnFilterByCategory);
            this.panelLeft.Controls.Add(this.btnDelete);
            this.panelLeft.Controls.Add(this.btnUpdate);
            this.panelLeft.Controls.Add(this.btnAdd);
            this.panelLeft.Controls.Add(this.btnList);
            this.panelLeft.Controls.Add(this.dtpSpendingDate);
            this.panelLeft.Controls.Add(this.cmbCategory);
            this.panelLeft.Controls.Add(this.txtSpendingAmount);
            this.panelLeft.Controls.Add(this.txtSpendingTitle);
            this.panelLeft.Controls.Add(this.lblSpendingDate);
            this.panelLeft.Controls.Add(this.lblCategory);
            this.panelLeft.Controls.Add(this.lblSpendingAmount);
            this.panelLeft.Controls.Add(this.lblSpendingTitle);
            this.panelLeft.Controls.Add(this.lblFormTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 85);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(380, 615);
            this.panelLeft.TabIndex = 1;

            // lblFormTitle
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(190, 120, 255);
            this.lblFormTitle.Location = new System.Drawing.Point(34, 20);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(190, 25);
            this.lblFormTitle.Text = "Harcama İşlemleri";

            // labels
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(34, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.Text = "İşlem ID:";

            this.lblSpendingTitle.AutoSize = true;
            this.lblSpendingTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSpendingTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSpendingTitle.Location = new System.Drawing.Point(34, 125);
            this.lblSpendingTitle.Name = "lblSpendingTitle";
            this.lblSpendingTitle.Size = new System.Drawing.Size(122, 19);
            this.lblSpendingTitle.Text = "Harcama Başlığı:";

            this.lblSpendingAmount.AutoSize = true;
            this.lblSpendingAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSpendingAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSpendingAmount.Location = new System.Drawing.Point(34, 185);
            this.lblSpendingAmount.Name = "lblSpendingAmount";
            this.lblSpendingAmount.Size = new System.Drawing.Size(48, 19);
            this.lblSpendingAmount.Text = "Tutar:";

            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCategory.Location = new System.Drawing.Point(34, 245);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(71, 19);
            this.lblCategory.Text = "Kategori:";

            this.lblSpendingDate.AutoSize = true;
            this.lblSpendingDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSpendingDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSpendingDate.Location = new System.Drawing.Point(34, 305);
            this.lblSpendingDate.Name = "lblSpendingDate";
            this.lblSpendingDate.Size = new System.Drawing.Size(46, 19);
            this.lblSpendingDate.Text = "Tarih:";

            // inputs
            this.txtSpendingId.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.txtSpendingId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpendingId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSpendingId.ForeColor = System.Drawing.Color.White;
            this.txtSpendingId.Location = new System.Drawing.Point(34, 88);
            this.txtSpendingId.MaxLength = 100;
            this.txtSpendingId.Name = "txtSpendingId";
            this.txtSpendingId.Size = new System.Drawing.Size(310, 27);
            this.txtSpendingId.TabIndex = 15;

            this.txtSpendingTitle.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.txtSpendingTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpendingTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSpendingTitle.ForeColor = System.Drawing.Color.White;
            this.txtSpendingTitle.Location = new System.Drawing.Point(34, 148);
            this.txtSpendingTitle.MaxLength = 100;
            this.txtSpendingTitle.Name = "txtSpendingTitle";
            this.txtSpendingTitle.Size = new System.Drawing.Size(310, 27);
            this.txtSpendingTitle.TabIndex = 3;

            this.txtSpendingAmount.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.txtSpendingAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpendingAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSpendingAmount.ForeColor = System.Drawing.Color.White;
            this.txtSpendingAmount.Location = new System.Drawing.Point(34, 208);
            this.txtSpendingAmount.Name = "txtSpendingAmount";
            this.txtSpendingAmount.Size = new System.Drawing.Size(310, 27);
            this.txtSpendingAmount.TabIndex = 4;
            this.txtSpendingAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpendingAmount_KeyPress);

            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCategory.ForeColor = System.Drawing.Color.White;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(34, 268);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(310, 28);
            this.cmbCategory.TabIndex = 5;

            this.dtpSpendingDate.CalendarForeColor = System.Drawing.Color.White;
            this.dtpSpendingDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(28, 28, 36);
            this.dtpSpendingDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpSpendingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSpendingDate.Location = new System.Drawing.Point(34, 328);
            this.dtpSpendingDate.Name = "dtpSpendingDate";
            this.dtpSpendingDate.Size = new System.Drawing.Size(310, 27);
            this.dtpSpendingDate.TabIndex = 6;

            // buttons
            this.btnList.BackColor = System.Drawing.Color.FromArgb(111, 52, 170);
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(34, 380);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(310, 42);
            this.btnList.TabIndex = 13;
            this.btnList.Text = "📋 Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);

            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(128, 61, 196);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(34, 430);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(310, 42);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "➕ Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(86, 76, 207);
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(34, 480);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(310, 42);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "✏️ Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(181, 48, 110);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(34, 530);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(310, 42);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "🗑️ Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnFilterByCategory.BackColor = System.Drawing.Color.FromArgb(70, 45, 120);
            this.btnFilterByCategory.FlatAppearance.BorderSize = 0;
            this.btnFilterByCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterByCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFilterByCategory.ForeColor = System.Drawing.Color.White;
            this.btnFilterByCategory.Location = new System.Drawing.Point(34, 580);
            this.btnFilterByCategory.Name = "btnFilterByCategory";
            this.btnFilterByCategory.Size = new System.Drawing.Size(150, 31);
            this.btnFilterByCategory.TabIndex = 10;
            this.btnFilterByCategory.Text = "🔍 Kategoriye Göre";
            this.btnFilterByCategory.UseVisualStyleBackColor = false;
            this.btnFilterByCategory.Click += new System.EventHandler(this.btnFilterByCategory_Click);

            this.btnToday.BackColor = System.Drawing.Color.FromArgb(70, 45, 120);
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(194, 580);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(150, 31);
            this.btnToday.TabIndex = 11;
            this.btnToday.Text = "📅 Bugünkü";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);

            // dataGridView1
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(24, 24, 32);
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 38, 78);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(32, 32, 42);
            this.dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(128, 61, 196);
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(70, 45, 100);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(380, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(900, 615);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // FrmSpendings
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSpendings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial CRM - Harcamalar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSpendings_FormClosing);
            this.Load += new System.EventHandler(this.FrmSpendings_Load);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnFilterByCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DateTimePicker dtpSpendingDate;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtSpendingAmount;
        private System.Windows.Forms.TextBox txtSpendingTitle;
        private System.Windows.Forms.Label lblSpendingDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSpendingAmount;
        private System.Windows.Forms.Label lblSpendingTitle;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSpendingId;
        private System.Windows.Forms.Label label1;
    }
}