namespace FinancialCrm
{
    partial class FrmAbout
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblTech;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblTech = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();

            this.panelMain.SuspendLayout();
            this.SuspendLayout();

            // FrmAbout
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 26);
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial CRM - Copyright";

            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(32, 25, 52);
            this.panelMain.Location = new System.Drawing.Point(40, 35);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(920, 640);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.lblDeveloper);
            this.panelMain.Controls.Add(this.lblContact);
            this.panelMain.Controls.Add(this.lblTech);
            this.panelMain.Controls.Add(this.lblLicense);
            this.panelMain.Controls.Add(this.btnBack);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(190, 120, 255);
            this.lblTitle.Location = new System.Drawing.Point(50, 40);
            this.lblTitle.Text = "📜 Financial CRM Copyright";

            // lblDeveloper
            this.lblDeveloper.AutoSize = false;
            this.lblDeveloper.Size = new System.Drawing.Size(700, 60);
            this.lblDeveloper.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDeveloper.ForeColor = System.Drawing.Color.White;
            this.lblDeveloper.Location = new System.Drawing.Point(55, 120);
            this.lblDeveloper.Text =
                "Developer : 👤 Reha Demircan\r\n" +
                "All Rights Reserved © 2026";

            // lblContact
            this.lblContact.AutoSize = false;
            this.lblContact.Size = new System.Drawing.Size(750, 60);
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.lblContact.Location = new System.Drawing.Point(55, 190);
            this.lblContact.Text =
                "🌐 LinkedIn: linkedin.com/in/reha-demircan-9656961b9\r\n" +
                "🐙 GitHub: github.com/rdmrcn";

            // lblTech
            this.lblTech.AutoSize = true;
            this.lblTech.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTech.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTech.Location = new System.Drawing.Point(55, 280);
            this.lblTech.Text =
                "🛠 Kullanılan Teknolojiler\n\n" +
                "• C# Windows Forms\n" +
                "• .NET Framework\n" +
                "• Entity Framework\n" +
                "• Microsoft SQL Server\n" +
                "• Visual Studio 2022\n" +
                "• Modern dark purple UI theme";

            // lblLicense
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblLicense.ForeColor = System.Drawing.Color.FromArgb(190, 120, 255);
            this.lblLicense.Location = new System.Drawing.Point(55, 560);
            this.lblLicense.Text = "📄 License: MIT License";

            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(106, 48, 147);
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(750, 560);
            this.btnBack.Size = new System.Drawing.Size(140, 50);
            this.btnBack.Text = "⬅ Geri";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.Controls.Add(this.panelMain);

            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}