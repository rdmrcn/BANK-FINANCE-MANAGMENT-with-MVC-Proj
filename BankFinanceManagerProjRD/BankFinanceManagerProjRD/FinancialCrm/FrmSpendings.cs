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
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            SpendingList();
            LoadCategories();
            ClearFields();
        }

        void SpendingList()
        {
            var values = db.Spendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                CategoryName = x.Categories.CategoryName
            }).OrderByDescending(x => x.SpendingDate).ToList();

            dataGridView1.DataSource = values;

            // DataGridView column headers
            dataGridView1.Columns[0].HeaderText = "Harcama ID";
            dataGridView1.Columns[1].HeaderText = "Harcama Başlığı";
            dataGridView1.Columns[2].HeaderText = "Tutar";
            dataGridView1.Columns[3].HeaderText = "Tarih";
            dataGridView1.Columns[4].HeaderText = "Kategori";

            // Format columns
            dataGridView1.Columns[2].DefaultCellStyle.Format = "C2"; // Currency format
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy"; // Date format
        }

        void LoadCategories()
        {
            // ComboBox'a kategorileri yükle
            var categories = db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName
            }).ToList();

            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.SelectedIndex = -1; // Hiçbiri seçili olmasın
        }

        void ClearFields()
        {
            txtSpendingId.Text = "";
            txtSpendingTitle.Text = "";
            txtSpendingAmount.Text = "";
            dtpSpendingDate.Value = DateTime.Now;
            cmbCategory.SelectedIndex = -1;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            SpendingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtSpendingTitle.Text))
                {
                    MessageBox.Show("Harcama başlığı boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSpendingTitle.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSpendingAmount.Text))
                {
                    MessageBox.Show("Harcama tutarı boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSpendingAmount.Focus();
                    return;
                }

                if (!decimal.TryParse(txtSpendingAmount.Text, out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("Geçerli bir tutar giriniz (0'dan büyük olmalı)!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSpendingAmount.Focus();
                    return;
                }

                if (cmbCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbCategory.Focus();
                    return;
                }

                Spendings spending = new Spendings()
                {
                    SpendingTitle = txtSpendingTitle.Text.Trim(),
                    SpendingAmount = amount,
                    SpendingDate = dtpSpendingDate.Value,
                    CategoryId = (int)cmbCategory.SelectedValue
                };

                db.Spendings.Add(spending);
                db.SaveChanges();

                MessageBox.Show("Harcama başarıyla eklendi!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SpendingList();
                ClearFields();
                txtSpendingTitle.Focus();
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
                // Validation
                if (string.IsNullOrEmpty(txtSpendingId.Text))
                {
                    MessageBox.Show("Güncellenecek harcamayı seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSpendingTitle.Text))
                {
                    MessageBox.Show("Harcama başlığı boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSpendingTitle.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSpendingAmount.Text))
                {
                    MessageBox.Show("Harcama tutarı boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSpendingAmount.Focus();
                    return;
                }

                if (!decimal.TryParse(txtSpendingAmount.Text, out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("Geçerli bir tutar giriniz (0'dan büyük olmalı)!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSpendingAmount.Focus();
                    return;
                }

                if (cmbCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbCategory.Focus();
                    return;
                }

                int spendingId = int.Parse(txtSpendingId.Text);
                var spending = db.Spendings.Find(spendingId);

                if (spending != null)
                {
                    spending.SpendingTitle = txtSpendingTitle.Text.Trim();
                    spending.SpendingAmount = amount;
                    spending.SpendingDate = dtpSpendingDate.Value;
                    spending.CategoryId = (int)cmbCategory.SelectedValue;

                    db.SaveChanges();

                    MessageBox.Show("Harcama başarıyla güncellendi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SpendingList();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Harcama bulunamadı!", "Hata",
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
                if (string.IsNullOrEmpty(txtSpendingId.Text))
                {
                    MessageBox.Show("Silinecek harcamayı seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int spendingId = int.Parse(txtSpendingId.Text);
                var spending = db.Spendings.Find(spendingId);

                if (spending != null)
                {
                    DialogResult result = MessageBox.Show(
                        $"'{spending.SpendingTitle}' harcamasını silmek istediğinizden emin misiniz?\n\n" +
                        $"Tutar: {spending.SpendingAmount:C2}\n" +
                        $"Tarih: {spending.SpendingDate:dd/MM/yyyy}",
                        "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        db.Spendings.Remove(spending);
                        db.SaveChanges();

                        MessageBox.Show("Harcama başarıyla silindi!", "Başarılı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SpendingList();
                        ClearFields();
                    }
                }
                else
                {
                    MessageBox.Show("Harcama bulunamadı!", "Hata",
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
                txtSpendingId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
                txtSpendingTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
                txtSpendingAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";

                // Date parsing
                if (DateTime.TryParse(dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString(), out DateTime spendingDate))
                {
                    dtpSpendingDate.Value = spendingDate;
                }

                // Category selection
                string categoryName = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";
                for (int i = 0; i < cmbCategory.Items.Count; i++)
                {
                    cmbCategory.SelectedIndex = i;
                    if (cmbCategory.Text == categoryName)
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

        private void FrmSpendings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                btnMainMenu_Click(sender, e);
            }
        }

        // Sadece sayı girişine izin ver (tutar için)
        private void txtSpendingAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sayı, backspace, delete ve virgül/nokta'ya izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Sadece bir ondalık ayraç olabilir
            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                (txtSpendingAmount.Text.Contains(".") || txtSpendingAmount.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        // Kategoriye göre filtreleme
        private void btnFilterByCategory_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Filtrelemek için bir kategori seçiniz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId = (int)cmbCategory.SelectedValue;
            var values = db.Spendings.Where(x => x.CategoryId == categoryId)
                .Select(x => new
                {
                    x.SpendingId,
                    x.SpendingTitle,
                    x.SpendingAmount,
                    x.SpendingDate,
                    CategoryName = x.Categories.CategoryName
                }).OrderByDescending(x => x.SpendingDate).ToList();

            dataGridView1.DataSource = values;
        }

        // Bugünkü harcamaları göster
        private void btnToday_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            var values = db.Spendings.Where(x => x.SpendingDate >= today && x.SpendingDate < today.AddDays(1))
                .Select(x => new
                {
                    x.SpendingId,
                    x.SpendingTitle,
                    x.SpendingAmount,
                    x.SpendingDate,
                    CategoryName = x.Categories.CategoryName
                }).OrderByDescending(x => x.SpendingDate).ToList();

            dataGridView1.DataSource = values;

            decimal totalToday = values.Sum(x => x.SpendingAmount) ?? 0;
            MessageBox.Show($"Bugünkü toplam harcama: {totalToday:C2}", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
