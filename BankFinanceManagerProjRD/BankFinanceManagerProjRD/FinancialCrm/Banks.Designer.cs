namespace FinancialCrm
{
    partial class FrmBanks
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtBankBalance = new System.Windows.Forms.TextBox();
            this.txtBankAccountNumber = new System.Windows.Forms.TextBox();
            this.txtBankTitle = new System.Windows.Forms.TextBox();
            this.txtBankId = new System.Windows.Forms.TextBox();
            this.lblBankBalance = new System.Windows.Forms.Label();
            this.lblBankAccountNumber = new System.Windows.Forms.Label();
            this.lblBankTitle = new System.Windows.Forms.Label();
            this.lblBankId = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panelHeader.Controls.Add(this.btnMainMenu);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(850, 15);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(120, 40);
            this.btnMainMenu.TabIndex = 8;
            this.btnMainMenu.Text = "🏠 Ana Menü";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏦 Banka Yönetimi";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelLeft.Controls.Add(this.btnDelete);
            this.panelLeft.Controls.Add(this.btnUpdate);
            this.panelLeft.Controls.Add(this.btnAdd);
            this.panelLeft.Controls.Add(this.btnList);
            this.panelLeft.Controls.Add(this.txtBankBalance);
            this.panelLeft.Controls.Add(this.txtBankAccountNumber);
            this.panelLeft.Controls.Add(this.txtBankTitle);
            this.panelLeft.Controls.Add(this.txtBankId);
            this.panelLeft.Controls.Add(this.lblBankBalance);
            this.panelLeft.Controls.Add(this.lblBankAccountNumber);
            this.panelLeft.Controls.Add(this.lblBankTitle);
            this.panelLeft.Controls.Add(this.lblBankId);
            this.panelLeft.Controls.Add(this.lblFormTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 70);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(320, 480);
            this.panelLeft.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(30, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(260, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "🗑️ Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(30, 356);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(260, 45);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "✏️ Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(30, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(260, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "➕ Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(30, 236);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(260, 45);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "📋 Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtBankBalance
            // 
            this.txtBankBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.txtBankBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBankBalance.ForeColor = System.Drawing.Color.White;
            this.txtBankBalance.Location = new System.Drawing.Point(30, 201);
            this.txtBankBalance.Name = "txtBankBalance";
            this.txtBankBalance.Size = new System.Drawing.Size(260, 29);
            this.txtBankBalance.TabIndex = 4;
            // 
            // txtBankAccountNumber
            // 
            this.txtBankAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.txtBankAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBankAccountNumber.ForeColor = System.Drawing.Color.White;
            this.txtBankAccountNumber.Location = new System.Drawing.Point(30, 147);
            this.txtBankAccountNumber.MaxLength = 50;
            this.txtBankAccountNumber.Name = "txtBankAccountNumber";
            this.txtBankAccountNumber.Size = new System.Drawing.Size(260, 29);
            this.txtBankAccountNumber.TabIndex = 3;
            // 
            // txtBankTitle
            // 
            this.txtBankTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.txtBankTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBankTitle.ForeColor = System.Drawing.Color.White;
            this.txtBankTitle.Location = new System.Drawing.Point(30, 100);
            this.txtBankTitle.MaxLength = 100;
            this.txtBankTitle.Name = "txtBankTitle";
            this.txtBankTitle.Size = new System.Drawing.Size(260, 29);
            this.txtBankTitle.TabIndex = 2;
            // 
            // txtBankId
            // 
            this.txtBankId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtBankId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankId.Enabled = false;
            this.txtBankId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBankId.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBankId.Location = new System.Drawing.Point(30, 50);
            this.txtBankId.Name = "txtBankId";
            this.txtBankId.ReadOnly = true;
            this.txtBankId.Size = new System.Drawing.Size(260, 29);
            this.txtBankId.TabIndex = 1;
            this.txtBankId.TabStop = false;
            // 
            // lblBankBalance
            // 
            this.lblBankBalance.AutoSize = true;
            this.lblBankBalance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBankBalance.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBankBalance.Location = new System.Drawing.Point(31, 179);
            this.lblBankBalance.Name = "lblBankBalance";
            this.lblBankBalance.Size = new System.Drawing.Size(103, 19);
            this.lblBankBalance.TabIndex = 0;
            this.lblBankBalance.Text = "Banka Balance:";
            // 
            // lblBankAccountNumber
            // 
            this.lblBankAccountNumber.AutoSize = true;
            this.lblBankAccountNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBankAccountNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBankAccountNumber.Location = new System.Drawing.Point(30, 125);
            this.lblBankAccountNumber.Name = "lblBankAccountNumber";
            this.lblBankAccountNumber.Size = new System.Drawing.Size(123, 19);
            this.lblBankAccountNumber.TabIndex = 0;
            this.lblBankAccountNumber.Text = "account Number:";
            // 
            // lblBankTitle
            // 
            this.lblBankTitle.AutoSize = true;
            this.lblBankTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBankTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBankTitle.Location = new System.Drawing.Point(30, 80);
            this.lblBankTitle.Name = "lblBankTitle";
            this.lblBankTitle.Size = new System.Drawing.Size(81, 19);
            this.lblBankTitle.TabIndex = 0;
            this.lblBankTitle.Text = "Banka Name:";
            // 
            // lblBankId
            // 
            this.lblBankId.AutoSize = true;
            this.lblBankId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBankId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBankId.Location = new System.Drawing.Point(30, 28);
            this.lblBankId.Name = "lblBankId";
            this.lblBankId.Size = new System.Drawing.Size(72, 19);
            this.lblBankId.TabIndex = 0;
            this.lblBankId.Text = "Banka ID:";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(29, 3);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(146, 25);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Banka Transactions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dataGridView1.Location = new System.Drawing.Point(320, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(680, 480);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial CRM - Banks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBanks_FormClosing);
            this.Load += new System.EventHandler(this.FrmBanks_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtBankBalance;
        private System.Windows.Forms.TextBox txtBankAccountNumber;
        private System.Windows.Forms.TextBox txtBankTitle;
        private System.Windows.Forms.TextBox txtBankId;
        private System.Windows.Forms.Label lblBankBalance;
        private System.Windows.Forms.Label lblBankAccountNumber;
        private System.Windows.Forms.Label lblBankTitle;
        private System.Windows.Forms.Label lblBankId;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}