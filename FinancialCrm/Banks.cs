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
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            BankList();
            ClearFields();
        }

        void BankList()
        {
            var values = db.Banks.Select(x => new
            {
                x.BankId,
                x.BankTitle,
                x.BankAccountNumber,
                x.BankBalance
            }).ToList();
            dataGridView1.DataSource = values;

            
            dataGridView1.Columns[0].HeaderText = "Banka ID";
            dataGridView1.Columns[1].HeaderText = "Banka Adı";
            dataGridView1.Columns[2].HeaderText = "Hesap Numarası";
            dataGridView1.Columns[3].HeaderText = "Bakiye";
        }

        void ClearFields()
        {
            txtBankId.Text = "";
            txtBankTitle.Text = "";
            txtBankAccountNumber.Text = "";
            txtBankBalance.Text = "";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            BankList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(txtBankTitle.Text) ||
                    string.IsNullOrEmpty(txtBankAccountNumber.Text) ||
                    string.IsNullOrEmpty(txtBankBalance.Text))
                {
                    MessageBox.Show("Tüm alanları doldurunuz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                if (!decimal.TryParse(txtBankBalance.Text, out decimal balance))
                {
                    MessageBox.Show("Bakiye alanına geçerli bir sayı giriniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Banks bank = new Banks()
                {
                    BankTitle = txtBankTitle.Text.Trim(),
                    BankAccountNumber = txtBankAccountNumber.Text.Trim(),
                    BankBalance = balance
                };

                db.Banks.Add(bank);
                db.SaveChanges();

                MessageBox.Show("Banka başarıyla eklendi!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                BankList();
                ClearFields();
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
                
                if (string.IsNullOrEmpty(txtBankId.Text))
                {
                    MessageBox.Show("Güncellenecek bankayı seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtBankTitle.Text) ||
                    string.IsNullOrEmpty(txtBankAccountNumber.Text) ||
                    string.IsNullOrEmpty(txtBankBalance.Text))
                {
                    MessageBox.Show("Tüm alanları doldurunuz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int bankId = int.Parse(txtBankId.Text);
                if (!decimal.TryParse(txtBankBalance.Text, out decimal balance))
                {
                    MessageBox.Show("Bakiye alanına geçerli bir sayı giriniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var bank = db.Banks.Find(bankId);
                if (bank != null)
                {
                    bank.BankTitle = txtBankTitle.Text.Trim();
                    bank.BankAccountNumber = txtBankAccountNumber.Text.Trim();
                    bank.BankBalance = balance;

                    db.SaveChanges();

                    MessageBox.Show("Banka başarıyla güncellendi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BankList();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Banka bulunamadı!", "Hata",
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
                if (string.IsNullOrEmpty(txtBankId.Text))
                {
                    MessageBox.Show("Silinecek bankayı seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bu bankayı silmek istediğinizden emin misiniz?",
                    "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int bankId = int.Parse(txtBankId.Text);
                    var bank = db.Banks.Find(bankId);

                    if (bank != null)
                    {
                        db.Banks.Remove(bank);
                        db.SaveChanges();

                        MessageBox.Show("Banka başarıyla silindi!", "Başarılı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BankList();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Banka bulunamadı!", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                txtBankId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBankTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtBankAccountNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtBankBalance.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frm = new FrmMainMenu();
            frm.Show();
            this.Hide();
        }

        private void FrmBanks_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                btnMainMenu_Click(sender, e);
            }
        }
    }
}
