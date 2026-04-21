using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            BankProcessList();
            LoadBanks();
            LoadProcessTypes();
            ClearFields();
        }

        void BankProcessList()
        {
            var values = db.BankProcesses.Select(x => new
            {
                x.BankProcessId,
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                BankName = x.Banks.BankTitle
            }).OrderByDescending(x => x.ProcessDate).ToList();

            dataGridView1.DataSource = values;

            
            dataGridView1.Columns[0].HeaderText = "İşlem ID";
            dataGridView1.Columns[1].HeaderText = "Açıklama";
            dataGridView1.Columns[2].HeaderText = "İşlem Tarihi";
            dataGridView1.Columns[3].HeaderText = "İşlem Tipi";
            dataGridView1.Columns[4].HeaderText = "Tutar";
            dataGridView1.Columns[5].HeaderText = "Banka";

            
            dataGridView1.Columns[4].DefaultCellStyle.Format = "C2"; 
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"; 

            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value?.ToString() == "Giriş")
                {
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.Green;
                }
                else if (row.Cells[3].Value?.ToString() == "Çıkış")
                {
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        void LoadBanks()
        {
            // ComboBox'a bankaları yükle
            var banks = db.Banks.Select(x => new
            {
                x.BankId,
                DisplayText = x.BankTitle + " (" + x.BankAccountNumber + ")"
            }).ToList();

            cmbBank.DataSource = banks;
            cmbBank.DisplayMember = "DisplayText";
            cmbBank.ValueMember = "BankId";
            cmbBank.SelectedIndex = -1; // Hiçbiri seçili olmasın
        }

        void LoadProcessTypes()
        {
            // Process Type ComboBox'ını doldur
            cmbProcessType.Items.Clear();
            cmbProcessType.Items.Add("Giriş");
            cmbProcessType.Items.Add("Çıkış");
            cmbProcessType.SelectedIndex = -1;
        }

        void ClearFields()
        {
            txtBankProcessId.Text = "";
            txtDescription.Text = "";
            txtAmount.Text = "";
            dtpProcessDate.Value = DateTime.Now;
            cmbProcessType.SelectedIndex = -1;
            cmbBank.SelectedIndex = -1;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            BankProcessList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Açıklama boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescription.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAmount.Text))
                {
                    MessageBox.Show("Tutar boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmount.Focus();
                    return;
                }

                if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("Geçerli bir tutar giriniz (0'dan büyük olmalı)!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmount.Focus();
                    return;
                }

                if (cmbProcessType.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen işlem tipini seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbProcessType.Focus();
                    return;
                }

                if (cmbBank.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir banka seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbBank.Focus();
                    return;
                }

                int bankId = (int)cmbBank.SelectedValue;
                string processType = cmbProcessType.SelectedItem.ToString();

                // Banka bakiyesi kontrolü (Çıkış işlemi için)
                var bank = db.Banks.Find(bankId);
                if (processType == "Çıkış" && bank.BankBalance < amount)
                {
                    DialogResult result = MessageBox.Show(
                        $"Yetersiz bakiye!\n\n" +
                        $"Mevcut Bakiye: {bank.BankBalance:C2}\n" +
                        $"İşlem Tutarı: {amount:C2}\n\n" +
                        $"Yine de devam etmek istiyor musunuz?",
                        "Yetersiz Bakiye", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                        return;
                }

                BankProcesses bankProcess = new BankProcesses()
                {
                    Description = txtDescription.Text.Trim(),
                    ProcessDate = dtpProcessDate.Value,
                    ProcessType = processType,
                    Amount = amount,
                    BankId = bankId
                };

                db.BankProcesses.Add(bankProcess);

                // Banka bakiyesini güncelle
                if (processType == "Giriş")
                {
                    bank.BankBalance += amount;
                }
                else // Çıkış
                {
                    bank.BankBalance -= amount;
                }

                db.SaveChanges();

                MessageBox.Show(
                    $"İşlem başarıyla eklendi!\n\n" +
                    $"Yeni Bakiye: {bank.BankBalance:C2}",
                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BankProcessList();
                ClearFields();
                txtDescription.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBankProcessId.Text))
                {
                    MessageBox.Show("Güncellenecek işlemi seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validation
                if (string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtAmount.Text) ||
                    cmbProcessType.SelectedIndex == -1 ||
                    cmbBank.SelectedIndex == -1)
                {
                    MessageBox.Show("Tüm alanları doldurunuz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtAmount.Text, out decimal newAmount) || newAmount <= 0)
                {
                    MessageBox.Show("Geçerli bir tutar giriniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int bankProcessId = int.Parse(txtBankProcessId.Text);
                var bankProcess = db.BankProcesses.Find(bankProcessId);

                if (bankProcess != null)
                {
                    // Eski işlemi geri al
                    var oldBank = db.Banks.Find(bankProcess.BankId);
                    if (bankProcess.ProcessType == "Giriş")
                    {
                        oldBank.BankBalance -= bankProcess.Amount ?? 0;
                    }
                    else
                    {
                        oldBank.BankBalance += bankProcess.Amount ?? 0;
                    }

                    // Yeni değerleri ata
                    bankProcess.Description = txtDescription.Text.Trim();
                    bankProcess.ProcessDate = dtpProcessDate.Value;
                    bankProcess.ProcessType = cmbProcessType.SelectedItem.ToString();
                    bankProcess.Amount = newAmount;
                    bankProcess.BankId = (int)cmbBank.SelectedValue;

                    // Yeni işlemi uygula
                    var newBank = db.Banks.Find(bankProcess.BankId);
                    if (bankProcess.ProcessType == "Giriş")
                    {
                        newBank.BankBalance += newAmount;
                    }
                    else
                    {
                        newBank.BankBalance -= newAmount;
                    }

                    db.SaveChanges();

                    MessageBox.Show("İşlem başarıyla güncellendi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BankProcessList();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("İşlem bulunamadı!", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBankProcessId.Text))
                {
                    MessageBox.Show("Silinecek işlemi seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int bankProcessId = int.Parse(txtBankProcessId.Text);
                var bankProcess = db.BankProcesses.Find(bankProcessId);

                if (bankProcess != null)
                {
                    DialogResult result = MessageBox.Show(
                        $"Bu işlemi silmek istediğinizden emin misiniz?\n\n" +
                        $"Açıklama: {bankProcess.Description}\n" +
                        $"Tutar: {bankProcess.Amount:C2}\n" +
                        $"Tip: {bankProcess.ProcessType}\n" +
                        $"Tarih: {bankProcess.ProcessDate:dd/MM/yyyy}\n\n" +
                        $"Bu işlem banka bakiyesini etkileyecektir!",
                        "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // İşlemi geri al (bakiyeyi düzelt)
                        var bank = db.Banks.Find(bankProcess.BankId);
                        if (bankProcess.ProcessType == "Giriş")
                        {
                            bank.BankBalance -= bankProcess.Amount ?? 0;
                        }
                        else // Çıkış
                        {
                            bank.BankBalance += bankProcess.Amount ?? 0;
                        }

                        db.BankProcesses.Remove(bankProcess);
                        db.SaveChanges();

                        MessageBox.Show(
                            $"İşlem başarıyla silindi!\n\n" +
                            $"Güncellenmiş Bakiye: {bank.BankBalance:C2}",
                            "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BankProcessList();
                        ClearFields();
                    }
                }
                else
                {
                    MessageBox.Show("İşlem bulunamadı!", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBankProcessId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
                txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";

                // Date parsing
                if (DateTime.TryParse(dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString(), out DateTime processDate))
                {
                    dtpProcessDate.Value = processDate;
                }

                // Process Type selection
                string processType = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
                cmbProcessType.SelectedItem = processType;

                txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";

                // Bank selection
                string bankName = dataGridView1.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? "";
                for (int i = 0; i < cmbBank.Items.Count; i++)
                {
                    cmbBank.SelectedIndex = i;
                    if (cmbBank.Text.Contains(bankName))
                        break;
                }
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frm = new FrmMainMenu();
            frm.Show();
            this.Hide();
        }

        private void FrmBankProcesses_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                btnMainMenu_Click(sender, e);
            }
        }

        // Sadece sayı girişine izin ver (tutar için)
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                (txtAmount.Text.Contains(".") || txtAmount.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        // Bankaya göre filtreleme
        private void btnFilterByBank_Click(object sender, EventArgs e)
        {
            if (cmbBank.SelectedIndex == -1)
            {
                MessageBox.Show("Filtrelemek için bir banka seçiniz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bankId = (int)cmbBank.SelectedValue;
            var values = db.BankProcesses.Where(x => x.BankId == bankId)
                .Select(x => new
                {
                    x.BankProcessId,
                    x.Description,
                    x.ProcessDate,
                    x.ProcessType,
                    x.Amount,
                    BankName = x.Banks.BankTitle
                }).OrderByDescending(x => x.ProcessDate).ToList();

            dataGridView1.DataSource = values;

            // Toplam giriş/çıkış hesapla
            decimal totalIn = values.Where(x => x.ProcessType == "Giriş").Sum(x => x.Amount) ?? 0;
            decimal totalOut = values.Where(x => x.ProcessType == "Çıkış").Sum(x => x.Amount) ?? 0;

            MessageBox.Show(
                $"Seçili Banka İstatistikleri:\n\n" +
                $"Toplam Giriş: {totalIn:C2}\n" +
                $"Toplam Çıkış: {totalOut:C2}\n" +
                $"Net: {(totalIn - totalOut):C2}",
                "Banka İstatistikleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Bugünkü işlemler
        private void btnToday_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            var values = db.BankProcesses.Where(x => x.ProcessDate >= today && x.ProcessDate < today.AddDays(1))
                .Select(x => new
                {
                    x.BankProcessId,
                    x.Description,
                    x.ProcessDate,
                    x.ProcessType,
                    x.Amount,
                    BankName = x.Banks.BankTitle
                }).OrderByDescending(x => x.ProcessDate).ToList();

            dataGridView1.DataSource = values;

            decimal totalIn = values.Where(x => x.ProcessType == "Giriş").Sum(x => x.Amount) ?? 0;
            decimal totalOut = values.Where(x => x.ProcessType == "Çıkış").Sum(x => x.Amount) ?? 0;

            MessageBox.Show(
                $"Bugünkü İşlemler:\n\n" +
                $"Giriş: {totalIn:C2}\n" +
                $"Çıkış: {totalOut:C2}\n" +
                $"Net: {(totalIn - totalOut):C2}",
                "Günlük Özet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
