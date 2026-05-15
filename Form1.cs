using OtoparkOtomasyonu.Services;
using OtoparkOtomasyonu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    
    public partial class FrmAnaSayfa : Form
    {
        private OtoparkService otoparkService = new OtoparkService();

        public FrmAnaSayfa()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
        private void Listele()
        {
            dgvAraclar.DataSource = null;
            dgvAraclar.DataSource = otoparkService.TumKayitlariGetir();

            lblToplamArac.Text = otoparkService.TumKayitlariGetir().Count.ToString();
            lblIceridekiArac.Text = otoparkService.IceridekiAraclariGetir().Count.ToString();
            lblToplamKazanc.Text = otoparkService.TumKayitlariGetir()
                .Sum(x => x.Ucret).ToString("0.00") + " TL";

            dgvAraclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvAraclar.ScrollBars = ScrollBars.Both;

            dgvAraclar.Columns["Id"].HeaderText = "Sıra";
            dgvAraclar.Columns["Plaka"].HeaderText = "Plaka";
            dgvAraclar.Columns["AracTuru"].HeaderText = "Araç Türü";
            dgvAraclar.Columns["GirisSaati"].HeaderText = "Giriş Saati";
            dgvAraclar.Columns["CikisSaati"].HeaderText = "Çıkış Saati";
            dgvAraclar.Columns["Ucret"].HeaderText = "Ücret";
            dgvAraclar.Columns["IcerideMi"].HeaderText = "Durum";

            dgvAraclar.Columns["Id"].Width = 60;
            dgvAraclar.Columns["Plaka"].Width = 140;
            dgvAraclar.Columns["AracTuru"].Width = 130;
            dgvAraclar.Columns["GirisSaati"].Width = 170;
            dgvAraclar.Columns["CikisSaati"].Width = 170;
            dgvAraclar.Columns["Ucret"].Width = 100;
            dgvAraclar.Columns["IcerideMi"].Width = 90;

            dgvAraclar.Columns["Id"].Visible = true;
            dgvAraclar.Columns["Ucret"].Visible = true;
            dgvAraclar.Columns["IcerideMi"].Visible = true;

            dgvAraclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAraclar.MultiSelect = false;
            dgvAraclar.ReadOnly = true;
            dgvAraclar.AllowUserToAddRows = false;

            dgvAraclar.EnableHeadersVisualStyles = false;
            dgvAraclar.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvAraclar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAraclar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvAraclar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAraclar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAraclar.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvAraclar.RowTemplate.Height = 30;

            foreach (DataGridViewRow row in dgvAraclar.Rows)
            {
                bool icerideMi = Convert.ToBoolean(row.Cells["IcerideMi"].Value);
                row.DefaultCellStyle.BackColor = icerideMi ? Color.LightGreen : Color.LightCoral;
            }
        }
        private void Temizle()
        {
            txtPlaka.Clear();
            cmbAracTuru.SelectedIndex = -1;
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                otoparkService.AracEkle(
                    txtPlaka.Text,
                    cmbAracTuru.Text
                );

                MessageBox.Show("Araç başarıyla eklendi.");

                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAraclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAraclar.CurrentRow != null)
            {
                txtPlaka.Text = dgvAraclar.CurrentRow.Cells["Plaka"].Value.ToString();
                cmbAracTuru.Text = dgvAraclar.CurrentRow.Cells["AracTuru"].Value.ToString();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvAraclar.CurrentRow.Cells["Id"].Value);
                decimal ucret = otoparkService.AracCikisYap(id);

                MessageBox.Show("Araç çıkışı yapıldı. Ücret: " + ucret.ToString("0.00") + " TL");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvAraclar.CurrentRow.Cells["Id"].Value);

                otoparkService.AracSil(id);

                MessageBox.Show("Kayıt silindi.");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvAraclar.CurrentRow.Cells["Id"].Value);

                otoparkService.AracGuncelle(
                    id,
                    txtPlaka.Text,
                    cmbAracTuru.Text
                );

                MessageBox.Show("Kayıt güncellendi.");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnAnaSayfaMenu_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Ana Sayfa";
            Listele();
        }

        private void btnAracGirisMenu_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Araç Giriş";
            txtPlaka.Focus();
        }

        private void btnAracCikisMenu_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Araç Çıkış";
            dgvAraclar.Focus();
        }

        private void btnRaporlarMenu_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Raporlar";
            Listele();

            MessageBox.Show(
                "Toplam Araç: " + lblToplamArac.Text +
                "\nİçerideki Araç: " + lblIceridekiArac.Text +
                "\nToplam Kazanç: " + lblToplamKazanc.Text,
                "Rapor Özeti"
            );
        }
    }
}
