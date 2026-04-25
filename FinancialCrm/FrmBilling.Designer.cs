namespace FinancialCrm
{
    partial class FrmBilling
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.btnRemoveBill = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnBillList = new System.Windows.Forms.Button();
            this.txtBillPeriod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Categories = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Spendings = new System.Windows.Forms.Button();
            this.btn_BankProcess = new System.Windows.Forms.Button();
            this.frm_Dashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();

            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // panel1 - Left Menu
            this.panel1.BackColor = System.Drawing.Color.FromArgb(32, 25, 52);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.frm_Dashboard);
            this.panel1.Controls.Add(this.btn_BankProcess);
            this.panel1.Controls.Add(this.btn_Spendings);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_Categories);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 700);
            this.panel1.TabIndex = 1;

            // btn_Categories
            this.btn_Categories.BackColor = System.Drawing.Color.FromArgb(111, 52, 170);
            this.btn_Categories.FlatAppearance.BorderSize = 0;
            this.btn_Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Categories.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Categories.ForeColor = System.Drawing.Color.White;
            this.btn_Categories.Location = new System.Drawing.Point(28, 55);
            this.btn_Categories.Name = "btn_Categories";
            this.btn_Categories.Size = new System.Drawing.Size(205, 48);
            this.btn_Categories.TabIndex = 0;
            this.btn_Categories.Text = "📂 Kategoriler";
            this.btn_Categories.UseVisualStyleBackColor = false;
            this.btn_Categories.Click += new System.EventHandler(this.btn_Categories_Click);

            // button2
            this.button2.BackColor = System.Drawing.Color.FromArgb(128, 61, 196);
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(28, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "🏦 Bankalar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // btn_Spendings
            this.btn_Spendings.BackColor = System.Drawing.Color.FromArgb(86, 76, 207);
            this.btn_Spendings.FlatAppearance.BorderSize = 0;
            this.btn_Spendings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Spendings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Spendings.ForeColor = System.Drawing.Color.White;
            this.btn_Spendings.Location = new System.Drawing.Point(28, 185);
            this.btn_Spendings.Name = "btn_Spendings";
            this.btn_Spendings.Size = new System.Drawing.Size(205, 48);
            this.btn_Spendings.TabIndex = 3;
            this.btn_Spendings.Text = "💳 Harcamalar";
            this.btn_Spendings.UseVisualStyleBackColor = false;
            this.btn_Spendings.Click += new System.EventHandler(this.btn_Spendings_Click);

            // btn_BankProcess
            this.btn_BankProcess.BackColor = System.Drawing.Color.FromArgb(109, 55, 170);
            this.btn_BankProcess.FlatAppearance.BorderSize = 0;
            this.btn_BankProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BankProcess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_BankProcess.ForeColor = System.Drawing.Color.White;
            this.btn_BankProcess.Location = new System.Drawing.Point(28, 250);
            this.btn_BankProcess.Name = "btn_BankProcess";
            this.btn_BankProcess.Size = new System.Drawing.Size(205, 48);
            this.btn_BankProcess.TabIndex = 4;
            this.btn_BankProcess.Text = "🔄 Banka Hareketleri";
            this.btn_BankProcess.UseVisualStyleBackColor = false;
            this.btn_BankProcess.Click += new System.EventHandler(this.btn_BankProcess_Click);

            // frm_Dashboard
            this.frm_Dashboard.BackColor = System.Drawing.Color.FromArgb(70, 45, 120);
            this.frm_Dashboard.FlatAppearance.BorderSize = 0;
            this.frm_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frm_Dashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.frm_Dashboard.ForeColor = System.Drawing.Color.White;
            this.frm_Dashboard.Location = new System.Drawing.Point(28, 315);
            this.frm_Dashboard.Name = "frm_Dashboard";
            this.frm_Dashboard.Size = new System.Drawing.Size(205, 48);
            this.frm_Dashboard.TabIndex = 5;
            this.frm_Dashboard.Text = "📊 Dashboard";
            this.frm_Dashboard.UseVisualStyleBackColor = false;
            this.frm_Dashboard.Click += new System.EventHandler(this.frm_Dashboard_Click);

            // btn_Exit
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(120, 35, 90);
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(28, 600);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(205, 48);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "🏠 Ana Menü";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);

            // panel2 - Form Panel
            this.panel2.BackColor = System.Drawing.Color.FromArgb(38, 38, 46);
            this.panel2.Controls.Add(this.btnUpdateBill);
            this.panel2.Controls.Add(this.btnRemoveBill);
            this.panel2.Controls.Add(this.btnCreateBill);
            this.panel2.Controls.Add(this.btnBillList);
            this.panel2.Controls.Add(this.txtBillPeriod);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBillAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBillTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBillId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(280, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 250);
            this.panel2.TabIndex = 2;

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.Text = "🧾 Fatura ID:";

            // txtBillId
            this.txtBillId.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.txtBillId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBillId.ForeColor = System.Drawing.Color.White;
            this.txtBillId.Location = new System.Drawing.Point(165, 25);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(740, 27);
            this.txtBillId.TabIndex = 1;

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(35, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.Text = "📌 Başlık:";

            // txtBillTitle
            this.txtBillTitle.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.txtBillTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBillTitle.ForeColor = System.Drawing.Color.White;
            this.txtBillTitle.Location = new System.Drawing.Point(165, 69);
            this.txtBillTitle.Name = "txtBillTitle";
            this.txtBillTitle.Size = new System.Drawing.Size(740, 27);
            this.txtBillTitle.TabIndex = 3;

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(35, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.Text = "💰 Miktar:";

            // txtBillAmount
            this.txtBillAmount.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.txtBillAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBillAmount.ForeColor = System.Drawing.Color.White;
            this.txtBillAmount.Location = new System.Drawing.Point(165, 113);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(740, 27);
            this.txtBillAmount.TabIndex = 5;

            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(35, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.Text = "📅 Periyot:";

            // txtBillPeriod
            this.txtBillPeriod.BackColor = System.Drawing.Color.FromArgb(28, 28, 36);
            this.txtBillPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillPeriod.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBillPeriod.ForeColor = System.Drawing.Color.White;
            this.txtBillPeriod.Location = new System.Drawing.Point(165, 157);
            this.txtBillPeriod.Name = "txtBillPeriod";
            this.txtBillPeriod.Size = new System.Drawing.Size(740, 27);
            this.txtBillPeriod.TabIndex = 7;

            // btnBillList
            this.btnBillList.BackColor = System.Drawing.Color.FromArgb(111, 52, 170);
            this.btnBillList.FlatAppearance.BorderSize = 0;
            this.btnBillList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBillList.ForeColor = System.Drawing.Color.White;
            this.btnBillList.Location = new System.Drawing.Point(165, 200);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(170, 35);
            this.btnBillList.TabIndex = 8;
            this.btnBillList.Text = "📋 Ödeme Listesi";
            this.btnBillList.UseVisualStyleBackColor = false;
            this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);

            // btnCreateBill
            this.btnCreateBill.BackColor = System.Drawing.Color.FromArgb(128, 61, 196);
            this.btnCreateBill.FlatAppearance.BorderSize = 0;
            this.btnCreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreateBill.ForeColor = System.Drawing.Color.White;
            this.btnCreateBill.Location = new System.Drawing.Point(345, 200);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(170, 35);
            this.btnCreateBill.TabIndex = 9;
            this.btnCreateBill.Text = "➕ Yeni Ödeme";
            this.btnCreateBill.UseVisualStyleBackColor = false;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);

            // btnRemoveBill
            this.btnRemoveBill.BackColor = System.Drawing.Color.FromArgb(181, 48, 110);
            this.btnRemoveBill.FlatAppearance.BorderSize = 0;
            this.btnRemoveBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveBill.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBill.Location = new System.Drawing.Point(525, 200);
            this.btnRemoveBill.Name = "btnRemoveBill";
            this.btnRemoveBill.Size = new System.Drawing.Size(170, 35);
            this.btnRemoveBill.TabIndex = 10;
            this.btnRemoveBill.Text = "🗑️ Ödeme Sil";
            this.btnRemoveBill.UseVisualStyleBackColor = false;
            this.btnRemoveBill.Click += new System.EventHandler(this.btnRemoveBill_Click);

            // btnUpdateBill
            this.btnUpdateBill.BackColor = System.Drawing.Color.FromArgb(86, 76, 207);
            this.btnUpdateBill.FlatAppearance.BorderSize = 0;
            this.btnUpdateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateBill.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBill.Location = new System.Drawing.Point(705, 200);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(200, 35);
            this.btnUpdateBill.TabIndex = 11;
            this.btnUpdateBill.Text = "✏️ Ödeme Güncelle";
            this.btnUpdateBill.UseVisualStyleBackColor = false;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);

            // panel3
            this.panel3.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(280, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 370);
            this.panel3.TabIndex = 3;

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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(70, 45, 100);
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(960, 370);
            this.dataGridView1.TabIndex = 0;

            // FrmBilling
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial CRM - Ödeme & Fatura Formu";
            this.Load += new System.EventHandler(this.FrmBilling_Load);

            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Button btnRemoveBill;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Button btnBillList;
        private System.Windows.Forms.TextBox txtBillPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Categories;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Spendings;
        private System.Windows.Forms.Button btn_BankProcess;
        private System.Windows.Forms.Button frm_Dashboard;
        private System.Windows.Forms.Panel panel1;
    }
}