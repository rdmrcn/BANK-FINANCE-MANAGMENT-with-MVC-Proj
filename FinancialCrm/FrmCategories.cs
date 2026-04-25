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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            CategoryList();
            ClearFields();
        }

        void CategoryList()
        {
            var values = db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName,
                SpendingCount = x.Spendings.Count() // Kaç harcama var bu kategoride
            }).ToList();
            dataGridView1.DataSource = values;

            // DataGridView column headers
            dataGridView1.Columns[0].HeaderText = "Kategori ID";
            dataGridView1.Columns[1].HeaderText = "Kategori Adı";
            dataGridView1.Columns[2].HeaderText = "Harcama Sayısı";
        }

        void ClearFields()
        {
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
                {
                    MessageBox.Show("Kategori adı boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategoryName.Focus();
                    return;
                }

                // Aynı isimde kategori var mı kontrol et
                string categoryName = txtCategoryName.Text.Trim();
                var existingCategory = db.Categories.FirstOrDefault(x => x.CategoryName.ToLower() == categoryName.ToLower());

                if (existingCategory != null)
                {
                    MessageBox.Show("Bu isimde bir kategori zaten mevcut!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategoryName.Focus();
                    return;
                }

                Categories category = new Categories()
                {
                    CategoryName = categoryName
                };

                db.Categories.Add(category);
                db.SaveChanges();

                MessageBox.Show("Kategori başarıyla eklendi!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CategoryList();
                ClearFields();
                txtCategoryName.Focus();
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
                if (string.IsNullOrEmpty(txtCategoryId.Text))
                {
                    MessageBox.Show("Güncellenecek kategoriyi seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
                {
                    MessageBox.Show("Kategori adı boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategoryName.Focus();
                    return;
                }

                int categoryId = int.Parse(txtCategoryId.Text);
                string categoryName = txtCategoryName.Text.Trim();

                // Aynı isimde başka kategori var mı kontrol et (kendisi hariç)
                var existingCategory = db.Categories.FirstOrDefault(x =>
                    x.CategoryName.ToLower() == categoryName.ToLower() && x.CategoryId != categoryId);

                if (existingCategory != null)
                {
                    MessageBox.Show("Bu isimde başka bir kategori zaten mevcut!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategoryName.Focus();
                    return;
                }

                var category = db.Categories.Find(categoryId);
                if (category != null)
                {
                    category.CategoryName = categoryName;
                    db.SaveChanges();

                    MessageBox.Show("Kategori başarıyla güncellendi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CategoryList();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Kategori bulunamadı!", "Hata",
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
                if (string.IsNullOrEmpty(txtCategoryId.Text))
                {
                    MessageBox.Show("Silinecek kategoriyi seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int categoryId = int.Parse(txtCategoryId.Text);
                var category = db.Categories.Find(categoryId);

                if (category != null)
                {
                    // Bu kategoriye ait harcamalar var mı kontrol et
                    int spendingCount = db.Spendings.Count(x => x.CategoryId == categoryId);

                    if (spendingCount > 0)
                    {
                        MessageBox.Show($"Bu kategoriye ait {spendingCount} adet harcama bulunmaktadır. " +
                            "Önce harcamaları siliniz veya başka kategoriye taşıyınız!", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show(
                        $"'{category.CategoryName}' kategorisini silmek istediğinizden emin misiniz?",
                        "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        db.Categories.Remove(category);
                        db.SaveChanges();

                        MessageBox.Show("Kategori başarıyla silindi!", "Başarılı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CategoryList();
                        ClearFields();
                    }
                }
                else
                {
                    MessageBox.Show("Kategori bulunamadı!", "Hata",
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
                txtCategoryId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
                txtCategoryName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frm = new FrmMainMenu();
            frm.Show();
            this.Hide();
        }

        private void FrmCategories_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                btnMainMenu_Click(sender, e);
            }
        }

        // Enter tuşu ile ekleme
        private void txtCategoryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        // Sadece harf ve boşluk girişine izin ver
        private void txtCategoryName_KeyPress2(object sender, KeyPressEventArgs e)
        {
            // Harf, boşluk, backspace ve delete'e izin ver
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Sadece harf girişi yapabilirsiniz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
