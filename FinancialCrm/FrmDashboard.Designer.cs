namespace FinancialCrm
{
    partial class FrmDashboard
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
            this.components = new System.ComponentModel.Container();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();

            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();

            this.panelBill = new System.Windows.Forms.Panel();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();

            this.panelLastProcess = new System.Windows.Forms.Panel();
            this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();

            this.panelMini = new System.Windows.Forms.Panel();
            this.lblMiniInfo = new System.Windows.Forms.Label();
            this.lblMiniTitle = new System.Windows.Forms.Label();

            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();

            this.timer1 = new System.Windows.Forms.Timer(this.components);

            this.panelHeader.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelBill.SuspendLayout();
            this.panelLastProcess.SuspendLayout();
            this.panelMini.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();

            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(32, 25, 52);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Location = new System.Drawing.Point(25, 20);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1230, 85);
            this.panelHeader.TabIndex = 0;

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "📊 Financial CRM Dashboard";

            // btnExit
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(106, 48, 147);
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1060, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "🏠 Ana Menü";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // panelTotal
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(80, 42, 130);
            this.panelTotal.Controls.Add(this.lblTotalBalance);
            this.panelTotal.Controls.Add(this.label1);
            this.panelTotal.Location = new System.Drawing.Point(25, 125);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(285, 125);
            this.panelTotal.TabIndex = 1;

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Text = "💼 Toplam Bakiye";

            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalBalance.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalance.Location = new System.Drawing.Point(20, 55);
            this.lblTotalBalance.Text = "0.00₺";

            // panelBill
            this.panelBill.BackColor = System.Drawing.Color.FromArgb(94, 49, 150);
            this.panelBill.Controls.Add(this.lblBillAmount);
            this.panelBill.Controls.Add(this.lblBillTitle);
            this.panelBill.Location = new System.Drawing.Point(340, 125);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(285, 125);
            this.panelBill.TabIndex = 2;

            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBillTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBillTitle.Location = new System.Drawing.Point(20, 18);
            this.lblBillTitle.Text = "🧾 Fatura Başlığı";

            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblBillAmount.ForeColor = System.Drawing.Color.White;
            this.lblBillAmount.Location = new System.Drawing.Point(20, 55);
            this.lblBillAmount.Text = "0.00₺";

            // panelLastProcess
            this.panelLastProcess.BackColor = System.Drawing.Color.FromArgb(109, 55, 170);
            this.panelLastProcess.Controls.Add(this.lblLastBankProcessAmount);
            this.panelLastProcess.Controls.Add(this.label7);
            this.panelLastProcess.Location = new System.Drawing.Point(655, 125);
            this.panelLastProcess.Name = "panelLastProcess";
            this.panelLastProcess.Size = new System.Drawing.Size(285, 125);
            this.panelLastProcess.TabIndex = 3;

            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(20, 18);
            this.label7.Text = "🔄 Gelen Son Havale";

            this.lblLastBankProcessAmount.AutoSize = true;
            this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblLastBankProcessAmount.ForeColor = System.Drawing.Color.White;
            this.lblLastBankProcessAmount.Location = new System.Drawing.Point(20, 55);
            this.lblLastBankProcessAmount.Text = "0.00₺";

            // panelMini
            this.panelMini.BackColor = System.Drawing.Color.FromArgb(50, 38, 78);
            this.panelMini.Controls.Add(this.lblMiniInfo);
            this.panelMini.Controls.Add(this.lblMiniTitle);
            this.panelMini.Location = new System.Drawing.Point(970, 125);
            this.panelMini.Name = "panelMini";
            this.panelMini.Size = new System.Drawing.Size(285, 125);
            this.panelMini.TabIndex = 4;

            this.lblMiniTitle.AutoSize = true;
            this.lblMiniTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMiniTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMiniTitle.Location = new System.Drawing.Point(20, 18);
            this.lblMiniTitle.Text = "⚡ Sistem Özeti";

            this.lblMiniInfo.AutoSize = true;
            this.lblMiniInfo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblMiniInfo.ForeColor = System.Drawing.Color.White;
            this.lblMiniInfo.Location = new System.Drawing.Point(20, 62);
            this.lblMiniInfo.Text = "Aktif";

            // chart1
            chartArea1.Name = "ChartArea1";
            chartArea1.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(55, 45, 75);
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(55, 45, 75);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(90, 60, 130);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(90, 60, 130);
            this.chart1.ChartAreas.Add(chartArea1);

            legend1.Name = "Legend1";
            legend1.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            legend1.ForeColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend1);

            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Banka Bakiyeleri";
            series1.Color = System.Drawing.Color.FromArgb(150, 95, 255);
            this.chart1.Series.Add(series1);

            this.chart1.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(80, 42, 130);
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.Location = new System.Drawing.Point(25, 275);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(590, 210);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";

            // chart2
            chartArea2.Name = "ChartArea1";
            chartArea2.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            this.chart2.ChartAreas.Add(chartArea2);

            legend2.Name = "Legend1";
            legend2.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            legend2.ForeColor = System.Drawing.Color.White;
            this.chart2.Legends.Add(legend2);

            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Faturalar";
            this.chart2.Series.Add(series2);

            this.chart2.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            this.chart2.BorderlineColor = System.Drawing.Color.FromArgb(80, 42, 130);
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart2.Location = new System.Drawing.Point(650, 275);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(605, 210);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";

            // chart3
            chartArea3.Name = "ChartArea1";
            chartArea3.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(55, 45, 75);
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(55, 45, 75);
            this.chart3.ChartAreas.Add(chartArea3);

            legend3.Name = "Legend1";
            legend3.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            legend3.ForeColor = System.Drawing.Color.White;
            this.chart3.Legends.Add(legend3);

            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Aylık Akış";
            series3.Color = System.Drawing.Color.FromArgb(190, 120, 255);
            this.chart3.Series.Add(series3);

            this.chart3.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            this.chart3.BorderlineColor = System.Drawing.Color.FromArgb(80, 42, 130);
            this.chart3.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart3.Location = new System.Drawing.Point(25, 515);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(590, 210);
            this.chart3.TabIndex = 7;
            this.chart3.Text = "chart3";

            // chart4
            chartArea4.Name = "ChartArea1";
            chartArea4.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(55, 45, 75);
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(55, 45, 75);
            this.chart4.ChartAreas.Add(chartArea4);

            legend4.Name = "Legend1";
            legend4.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            legend4.ForeColor = System.Drawing.Color.White;
            this.chart4.Legends.Add(legend4);

            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Kategori Dağılımı";
            this.chart4.Series.Add(series4);

            this.chart4.BackColor = System.Drawing.Color.FromArgb(24, 24, 32);
            this.chart4.BorderlineColor = System.Drawing.Color.FromArgb(80, 42, 130);
            this.chart4.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart4.Location = new System.Drawing.Point(650, 515);
            this.chart4.Name = "chart4";
            this.chart4.Size = new System.Drawing.Size(605, 210);
            this.chart4.TabIndex = 8;
            this.chart4.Text = "chart4";

            // timer1
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // FrmDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 26);
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panelMini);
            this.Controls.Add(this.panelLastProcess);
            this.Controls.Add(this.panelBill);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial CRM - Dashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();

            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();

            this.panelBill.ResumeLayout(false);
            this.panelBill.PerformLayout();

            this.panelLastProcess.ResumeLayout(false);
            this.panelLastProcess.PerformLayout();

            this.panelMini.ResumeLayout(false);
            this.panelMini.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panelBill;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label lblBillTitle;

        private System.Windows.Forms.Panel panelLastProcess;
        private System.Windows.Forms.Label lblLastBankProcessAmount;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Panel panelMini;
        private System.Windows.Forms.Label lblMiniInfo;
        private System.Windows.Forms.Label lblMiniTitle;

        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}