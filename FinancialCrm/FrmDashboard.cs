using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            LoadCards();
            LoadChart1();
            LoadChart2();
            LoadChart3();
            LoadChart4();
        }

        private void LoadCards()
        {
            decimal totalBalance = db.Banks.Any()
                ? db.Banks.Sum(x => (decimal?)x.BankBalance) ?? 0
                : 0;

            lblTotalBalance.Text = totalBalance.ToString("N2") + "₺";

            var lastBill = db.Bills.OrderByDescending(x => x.BillId).FirstOrDefault();
            if (lastBill != null)
            {
                lblBillTitle.Text = lastBill.BillTitle;

                // 🔥 FIX
                lblBillAmount.Text = Convert.ToDecimal(lastBill.BillAmount).ToString("N2") + "₺";
            }
            else
            {
                lblBillTitle.Text = "Fatura Yok";
                lblBillAmount.Text = "0.00₺";
            }

            var lastProcess = db.BankProcesses.OrderByDescending(x => x.BankProcessId).FirstOrDefault();
            if (lastProcess != null)

                // 🔥 FIX
                lblLastBankProcessAmount.Text = Convert.ToDecimal(lastProcess.Amount).ToString("N2") + "₺";

            else
                lblLastBankProcessAmount.Text = "0.00₺";

            lblMiniInfo.Text = "Aktif";
        }

        private void LoadChart1()
        {
            Series s = chart1.Series[0];
            s.Points.Clear();
            s.Name = "Banka Bakiyeleri";
            s.ChartType = SeriesChartType.Column;
            s.Color = Color.FromArgb(140, 75, 215);

            foreach (var bank in db.Banks.ToList())
            {
                s.Points.AddXY(bank.BankTitle, bank.BankBalance);
            }

            StyleChart(chart1);
        }

        private void LoadChart2()
        {
            Series s = chart2.Series[0];
            s.Points.Clear();
            s.Name = "Faturalar";
            s.ChartType = SeriesChartType.Column;
            s.Color = Color.FromArgb(80, 145, 235);

            foreach (var bill in db.Bills.ToList())
            {
                s.Points.AddXY(bill.BillTitle, bill.BillAmount);
            }

            StyleChart(chart2);
        }

        private void LoadChart3()
        {
            Series s = chart3.Series[0];
            s.Points.Clear();
            s.Name = "Aylık Finans Akışı";
            s.ChartType = SeriesChartType.SplineArea;
            s.Color = Color.FromArgb(120, 140, 75, 215);
            s.BorderWidth = 3;
            s.BorderColor = Color.FromArgb(190, 120, 255);

            s.Points.AddXY("Ocak", 32000);
            s.Points.AddXY("Şubat", 45000);
            s.Points.AddXY("Mart", 28000);
            s.Points.AddXY("Nisan", 61000);
            s.Points.AddXY("Mayıs", 52000);
            s.Points.AddXY("Haziran", 76000);

            StyleChart(chart3);
        }

        private void LoadChart4()
        {
            Series s = chart4.Series[0];
            s.Points.Clear();
            s.Name = "Harcama Dağılımı";
            s.ChartType = SeriesChartType.Doughnut;
            s["DoughnutRadius"] = "60";
            s.IsValueShownAsLabel = true;
            s.LabelForeColor = Color.White;
            s.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            s.Points.AddXY("Faturalar", 35);
            s.Points.AddXY("Market", 25);
            s.Points.AddXY("Ulaşım", 15);
            s.Points.AddXY("Eğlence", 10);
            s.Points.AddXY("Diğer", 15);

            s.Points[0].Color = Color.FromArgb(140, 75, 215);
            s.Points[1].Color = Color.FromArgb(86, 76, 207);
            s.Points[2].Color = Color.FromArgb(181, 48, 110);
            s.Points[3].Color = Color.FromArgb(109, 55, 170);
            s.Points[4].Color = Color.FromArgb(70, 45, 120);

            StyleChart(chart4);
        }

        private void StyleChart(Chart chart)
        {
            chart.BackColor = Color.FromArgb(24, 24, 32);
            chart.BorderlineColor = Color.FromArgb(80, 42, 130);
            chart.BorderlineDashStyle = ChartDashStyle.Solid;

            if (chart.ChartAreas.Count > 0)
            {
                ChartArea area = chart.ChartAreas[0];
                area.BackColor = Color.FromArgb(24, 24, 32);
                area.AxisX.LabelStyle.ForeColor = Color.Gainsboro;
                area.AxisY.LabelStyle.ForeColor = Color.Gainsboro;
                area.AxisX.LineColor = Color.FromArgb(90, 60, 130);
                area.AxisY.LineColor = Color.FromArgb(90, 60, 130);
                area.AxisX.MajorGrid.LineColor = Color.FromArgb(55, 45, 75);
                area.AxisY.MajorGrid.LineColor = Color.FromArgb(55, 45, 75);
            }

            if (chart.Legends.Count > 0)
            {
                chart.Legends[0].BackColor = Color.FromArgb(24, 24, 32);
                chart.Legends[0].ForeColor = Color.White;
                chart.Legends[0].Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMainMenu frm = new FrmMainMenu();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}