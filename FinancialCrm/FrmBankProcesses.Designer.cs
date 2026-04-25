namespace FinancialCrm
{
    partial class FrmBankProcesses
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
            this.btnToday = new System.Windows.Forms.Button();
            this.btnFilterByBank = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.cmbProcessType = new System.Windows.Forms.ComboBox();
            this.dtpProcessDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtBankProcessId = new System.Windows.Forms.TextBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblProcessType = new System.Windows.Forms.Label();
            this.lblProcessDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBankProcessId = new System.Windows.Forms.Label();
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
            this.btnMainMenu.TabIndex = 14;
            this.btnMainMenu.Text = "🏠 Ana Menü";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(35, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🔄 Banka İşlem Yönetimi";

            // panelLeft
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(38, 38, 46);
            this.panelLeft.Controls.Add(this.btnToday);
            this.panelLeft.Controls.Add(this.btnFilterByBank);
            this.panelLeft.Controls.Add(this.btnDelete);
            this.panelLeft.Controls.Add(this.btnUpdate);
            this.panelLeft.Controls.Add(this.btnAdd);
            this.panelLeft.Controls.Add(this.btnList);
            this.panelLeft.Controls.Add(this.cmbBank);
            this.panelLeft.Controls.Add(this.cmbProcessType);
            this.panelLeft.Controls.Add(this.dtpProcessDate);
            this.panelLeft.Controls.Add(this.txtAmount);
            this.panelLeft.Controls.Add(this.txtDescription);
            this.panelLeft.Controls.Add(this.txtBankProcessId);
            this.panelLeft.Controls.Add(this.lblBank);
            this.panelLeft.Controls.Add(this.lblProcessType);
            this.panelLeft.Controls.Add(this.lblProcessDate);
            this.panelLeft.Controls.Add(this.lblAmount);
            this.panelLeft.Controls.Add(this.lblDescription);
            this.panelLeft.Controls.Add(this.lblBankProcessId);
            this.panelLeft.Controls.Add(this.lblFormTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 85);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(390, 615);
            this.panelLeft.TabIndex = 1;

            // common textbox style
            this.txtBankProcessId.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.txtBankProcessId.ForeColor = System.Drawing.Color.White;
            this.txtBankProcessId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.cmbProcessType.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.cmbProcessType.ForeColor = System.Drawing.Color.White;
            this.cmbBank.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.cmbBank.ForeColor = System.Drawing.Color.White;
            this.dtpProcessDate.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.dtpProcessDate.ForeColor = System.Drawing.Color.White;

            // lblFormTitle
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(190, 120, 255);
            this.lblFormTitle.Location = new System.Drawing.Point(30, 18);
            this.lblFormTitle.Text = "Banka İşlem Formu";

            // labels
            System.Drawing.Color labelColor = System.Drawing.Color.Gainsboro;

            this.lblBankProcessId.AutoSize = true;
            this.lblBankProcessId.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBankProcessId.ForeColor = labelColor;
            this.lblBankProcessId.Location = new System.Drawing.Point(30, 58);
            this.lblBankProcessId.Text = "İşlem ID:";

            this.txtBankProcessId.Enabled = false;
            this.txtBankProcessId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBankProcessId.Location = new System.Drawing.Point(30, 82);
            this.txtBankProcessId.ReadOnly = true;
            this.txtBankProcessId.Size = new System.Drawing.Size(330, 25);

            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = labelColor;
            this.lblDescription.Location = new System.Drawing.Point(30, 122);
            this.lblDescription.Text = "Açıklama:";

            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = labelColor;
            this.lblAmount.Location = new System.Drawing.Point(205, 122);
            this.lblAmount.Text = "Tutar:";

            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(30, 146);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(160, 25);
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);

            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAmount.Location = new System.Drawing.Point(205, 146);
            this.txtAmount.Size = new System.Drawing.Size(155, 25);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);

            this.lblProcessDate.AutoSize = true;
            this.lblProcessDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblProcessDate.ForeColor = labelColor;
            this.lblProcessDate.Location = new System.Drawing.Point(30, 188);
            this.lblProcessDate.Text = "İşlem Tarihi:";

            this.dtpProcessDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpProcessDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpProcessDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProcessDate.Location = new System.Drawing.Point(30, 212);
            this.dtpProcessDate.ShowUpDown = true;
            this.dtpProcessDate.Size = new System.Drawing.Size(330, 25);

            this.lblProcessType.AutoSize = true;
            this.lblProcessType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblProcessType.ForeColor = labelColor;
            this.lblProcessType.Location = new System.Drawing.Point(30, 252);
            this.lblProcessType.Text = "İşlem Tipi:";

            this.cmbProcessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcessType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProcessType.Location = new System.Drawing.Point(30, 276);
            this.cmbProcessType.Size = new System.Drawing.Size(330, 25);

            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBank.ForeColor = labelColor;
            this.lblBank.Location = new System.Drawing.Point(30, 316);
            this.lblBank.Text = "Banka:";

            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBank.Location = new System.Drawing.Point(30, 340);
            this.cmbBank.Size = new System.Drawing.Size(330, 25);

            // buttons
            this.btnList.BackColor = System.Drawing.Color.FromArgb(111, 52, 170);
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(30, 385);
            this.btnList.Size = new System.Drawing.Size(330, 42);
            this.btnList.Text = "📋 Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);

            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(128, 61, 196);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(30, 435);
            this.btnAdd.Size = new System.Drawing.Size(330, 42);
            this.btnAdd.Text = "➕ Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(86, 76, 207);
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(30, 485);
            this.btnUpdate.Size = new System.Drawing.Size(330, 42);
            this.btnUpdate.Text = "✏️ Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(181, 48, 110);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(30, 535);
            this.btnDelete.Size = new System.Drawing.Size(330, 42);
            this.btnDelete.Text = "🗑️ Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnFilterByBank.BackColor = System.Drawing.Color.FromArgb(70, 45, 120);
            this.btnFilterByBank.FlatAppearance.BorderSize = 0;
            this.btnFilterByBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterByBank.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFilterByBank.ForeColor = System.Drawing.Color.White;
            this.btnFilterByBank.Location = new System.Drawing.Point(30, 584);
            this.btnFilterByBank.Size = new System.Drawing.Size(160, 31);
            this.btnFilterByBank.Text = "🔍 Bankaya Göre";
            this.btnFilterByBank.UseVisualStyleBackColor = false;
            this.btnFilterByBank.Click += new System.EventHandler(this.btnFilterByBank_Click);

            this.btnToday.BackColor = System.Drawing.Color.FromArgb(70, 45, 120);
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(200, 584);
            this.btnToday.Size = new System.Drawing.Size(160, 31);
            this.btnToday.Text = "📅 Buguku";
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
            this.dataGridView1.Location = new System.Drawing.Point(390, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(890, 615);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // FrmBankProcesses
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBankProcesses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial CRM - Banka Islemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBankProcesses_FormClosing);
            this.Load += new System.EventHandler(this.FrmBankProcesses_Load);

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
        private System.Windows.Forms.Button btnFilterByBank;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.ComboBox cmbProcessType;
        private System.Windows.Forms.DateTimePicker dtpProcessDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtBankProcessId;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblProcessType;
        private System.Windows.Forms.Label lblProcessDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBankProcessId;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}