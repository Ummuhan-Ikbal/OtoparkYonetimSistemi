namespace OtoparkOtomasyonu
{
    partial class FrmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAracCikisMenu = new System.Windows.Forms.Button();
            this.btnAracGirisMenu = new System.Windows.Forms.Button();
            this.btnRaporlarMenu = new System.Windows.Forms.Button();
            this.btnAnaSayfaMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelKazanc = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplamKazanc = new System.Windows.Forms.Label();
            this.panelIceride = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIceridekiArac = new System.Windows.Forms.Label();
            this.lblToplamArac = new System.Windows.Forms.Label();
            this.panelToplam = new System.Windows.Forms.Panel();
            this.panellceride = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAraclar = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbAracTuru = new System.Windows.Forms.ComboBox();
            this.lblTur = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelKazanc.SuspendLayout();
            this.panelIceride.SuspendLayout();
            this.panelToplam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            this.SuspendLayout();
           
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.btnAracCikisMenu);
            this.panelMenu.Controls.Add(this.btnAracGirisMenu);
            this.panelMenu.Controls.Add(this.btnRaporlarMenu);
            this.panelMenu.Controls.Add(this.btnAnaSayfaMenu);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 666);
            this.panelMenu.TabIndex = 0;
            
            this.btnAracCikisMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAracCikisMenu.Font = new System.Drawing.Font("Segoe UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracCikisMenu.ForeColor = System.Drawing.Color.White;
            this.btnAracCikisMenu.Location = new System.Drawing.Point(15, 240);
            this.btnAracCikisMenu.Name = "btnAracCikisMenu";
            this.btnAracCikisMenu.Size = new System.Drawing.Size(220, 45);
            this.btnAracCikisMenu.TabIndex = 4;
            this.btnAracCikisMenu.Text = "Araç Çıkış";
            this.btnAracCikisMenu.UseVisualStyleBackColor = false;
            this.btnAracCikisMenu.Click += new System.EventHandler(this.btnAracCikisMenu_Click);
            
            this.btnAracGirisMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAracGirisMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracGirisMenu.Font = new System.Drawing.Font("Segoe UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracGirisMenu.ForeColor = System.Drawing.Color.White;
            this.btnAracGirisMenu.Location = new System.Drawing.Point(15, 180);
            this.btnAracGirisMenu.Name = "btnAracGirisMenu";
            this.btnAracGirisMenu.Size = new System.Drawing.Size(220, 45);
            this.btnAracGirisMenu.TabIndex = 3;
            this.btnAracGirisMenu.Text = "Araç Girişi";
            this.btnAracGirisMenu.UseVisualStyleBackColor = false;
            this.btnAracGirisMenu.Click += new System.EventHandler(this.btnAracGirisMenu_Click);
            
            this.btnRaporlarMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRaporlarMenu.Font = new System.Drawing.Font("Segoe UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlarMenu.ForeColor = System.Drawing.Color.White;
            this.btnRaporlarMenu.Location = new System.Drawing.Point(15, 300);
            this.btnRaporlarMenu.Name = "btnRaporlarMenu";
            this.btnRaporlarMenu.Size = new System.Drawing.Size(220, 45);
            this.btnRaporlarMenu.TabIndex = 2;
            this.btnRaporlarMenu.Text = "Raporlar";
            this.btnRaporlarMenu.UseVisualStyleBackColor = false;
            this.btnRaporlarMenu.Click += new System.EventHandler(this.btnRaporlarMenu_Click);
           
            this.btnAnaSayfaMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAnaSayfaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfaMenu.Font = new System.Drawing.Font("Segoe UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfaMenu.ForeColor = System.Drawing.Color.White;
            this.btnAnaSayfaMenu.Location = new System.Drawing.Point(15, 120);
            this.btnAnaSayfaMenu.Name = "btnAnaSayfaMenu";
            this.btnAnaSayfaMenu.Size = new System.Drawing.Size(220, 45);
            this.btnAnaSayfaMenu.TabIndex = 1;
            this.btnAnaSayfaMenu.Text = "Ana Sayfa";
            this.btnAnaSayfaMenu.UseVisualStyleBackColor = false;
            this.btnAnaSayfaMenu.Click += new System.EventHandler(this.btnAnaSayfaMenu_Click);
            
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "OTOPARK";
            
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTop.Controls.Add(this.lblBaslik);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(250, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(750, 100);
            this.panelTop.TabIndex = 1;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
           
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(20, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(230, 59);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Ana Sayfa";
           
            this.panelContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.Controls.Add(this.panelKazanc);
            this.panelContent.Controls.Add(this.panelIceride);
            this.panelContent.Controls.Add(this.lblToplamArac);
            this.panelContent.Controls.Add(this.panelToplam);
            this.panelContent.Controls.Add(this.dgvAraclar);
            this.panelContent.Controls.Add(this.btnGuncelle);
            this.panelContent.Controls.Add(this.btnSil);
            this.panelContent.Controls.Add(this.btnCikis);
            this.panelContent.Controls.Add(this.btnKaydet);
            this.panelContent.Controls.Add(this.cmbAracTuru);
            this.panelContent.Controls.Add(this.lblTur);
            this.panelContent.Controls.Add(this.txtPlaka);
            this.panelContent.Controls.Add(this.lblPlaka);
            this.panelContent.Controls.Add(this.lblTarih);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(750, 566);
            this.panelContent.TabIndex = 2;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            
            this.panelKazanc.BackColor = System.Drawing.Color.DarkOrange;
            this.panelKazanc.Controls.Add(this.label6);
            this.panelKazanc.Controls.Add(this.lblToplamKazanc);
            this.panelKazanc.Location = new System.Drawing.Point(536, 20);
            this.panelKazanc.Name = "panelKazanc";
            this.panelKazanc.Size = new System.Drawing.Size(220, 80);
            this.panelKazanc.TabIndex = 1;
            
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 78);
            this.label6.TabIndex = 3;
            
            this.lblToplamKazanc.AutoSize = true;
            this.lblToplamKazanc.Font = new System.Drawing.Font("Segoe UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKazanc.ForeColor = System.Drawing.Color.White;
            this.lblToplamKazanc.Location = new System.Drawing.Point(15, 10);
            this.lblToplamKazanc.Name = "lblToplamKazanc";
            this.lblToplamKazanc.Size = new System.Drawing.Size(213, 37);
            this.lblToplamKazanc.TabIndex = 0;
            this.lblToplamKazanc.Text = "Toplam Kazanç";
            
            this.panelIceride.BackColor = System.Drawing.Color.ForestGreen;
            this.panelIceride.Controls.Add(this.label4);
            this.panelIceride.Controls.Add(this.label3);
            this.panelIceride.Controls.Add(this.lblIceridekiArac);
            this.panelIceride.Location = new System.Drawing.Point(280, 20);
            this.panelIceride.Name = "panelIceride";
            this.panelIceride.Size = new System.Drawing.Size(220, 80);
            this.panelIceride.TabIndex = 11;
           
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 78);
            this.label4.TabIndex = 2;
            
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            
            this.lblIceridekiArac.AutoSize = true;
            this.lblIceridekiArac.Font = new System.Drawing.Font("Segoe UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIceridekiArac.ForeColor = System.Drawing.Color.White;
            this.lblIceridekiArac.Location = new System.Drawing.Point(15, 10);
            this.lblIceridekiArac.Name = "lblIceridekiArac";
            this.lblIceridekiArac.Size = new System.Drawing.Size(191, 37);
            this.lblIceridekiArac.TabIndex = 0;
            this.lblIceridekiArac.Text = "İçerideki Araç";
            
            this.lblToplamArac.AutoSize = true;
            this.lblToplamArac.BackColor = System.Drawing.Color.White;
            this.lblToplamArac.Font = new System.Drawing.Font("Segoe UI", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamArac.Location = new System.Drawing.Point(15, 35);
            this.lblToplamArac.Name = "lblToplamArac";
            this.lblToplamArac.Size = new System.Drawing.Size(0, 78);
            this.lblToplamArac.TabIndex = 1;
            
            this.panelToplam.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelToplam.Controls.Add(this.panellceride);
            this.panelToplam.Controls.Add(this.label2);
            this.panelToplam.Controls.Add(this.lblToplamArac);
            this.panelToplam.Location = new System.Drawing.Point(30, 20);
            this.panelToplam.Name = "panelToplam";
            this.panelToplam.Size = new System.Drawing.Size(220, 80);
            this.panelToplam.TabIndex = 10;
            
            this.panellceride.BackColor = System.Drawing.Color.ForestGreen;
            this.panellceride.Location = new System.Drawing.Point(280, 20);
            this.panellceride.Name = "panellceride";
            this.panellceride.Size = new System.Drawing.Size(220, 80);
            this.panellceride.TabIndex = 2;
            
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Toplam Araç";
            
            this.dgvAraclar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAraclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAraclar.Location = new System.Drawing.Point(30, 260);
            this.dgvAraclar.MultiSelect = false;
            this.dgvAraclar.Name = "dgvAraclar";
            this.dgvAraclar.ReadOnly = true;
            this.dgvAraclar.RowHeadersWidth = 82;
            this.dgvAraclar.RowTemplate.Height = 33;
            this.dgvAraclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAraclar.Size = new System.Drawing.Size(1000, 350);
            this.dgvAraclar.TabIndex = 9;
            this.dgvAraclar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAraclar_CellContentClick);
            
            this.btnGuncelle.BackColor = System.Drawing.Color.Orange;
            this.btnGuncelle.Location = new System.Drawing.Point(390, 190);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(133, 40);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            
            this.btnSil.BackColor = System.Drawing.Color.Firebrick;
            this.btnSil.Location = new System.Drawing.Point(529, 190);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 40);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
           
            this.btnCikis.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCikis.Location = new System.Drawing.Point(220, 190);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(160, 40);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Araç Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            
            this.btnKaydet.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(30, 190);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(180, 40);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Araç Giriş Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            
            this.cmbAracTuru.FormattingEnabled = true;
            this.cmbAracTuru.Items.AddRange(new object[] {
            "Otomobil",
            "Motosiklet",
            "Kamyonet"});
            this.cmbAracTuru.Location = new System.Drawing.Point(280, 150);
            this.cmbAracTuru.Name = "cmbAracTuru";
            this.cmbAracTuru.Size = new System.Drawing.Size(200, 45);
            this.cmbAracTuru.TabIndex = 4;
           
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(280, 130);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(129, 37);
            this.lblTur.TabIndex = 3;
            this.lblTur.Text = "Araç Türü";
            
            this.txtPlaka.Location = new System.Drawing.Point(30, 150);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(220, 43);
            this.txtPlaka.TabIndex = 2;
           
            this.lblPlaka.Location = new System.Drawing.Point(23, 130);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(116, 42);
            this.lblPlaka.TabIndex = 1;
            this.lblPlaka.Text = "Plaka:";
            
            this.lblTarih.AutoSize = true;
            this.lblTarih.ForeColor = System.Drawing.Color.Black;
            this.lblTarih.Location = new System.Drawing.Point(900, 25);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(90, 37);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "label2";
            
            this.timerSaat.Enabled = true;
            this.timerSaat.Interval = 1000;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 666);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelKazanc.ResumeLayout(false);
            this.panelKazanc.PerformLayout();
            this.panelIceride.ResumeLayout(false);
            this.panelIceride.PerformLayout();
            this.panelToplam.ResumeLayout(false);
            this.panelToplam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnRaporlarMenu;
        private System.Windows.Forms.Button btnAnaSayfaMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAracCikisMenu;
        private System.Windows.Forms.Button btnAracGirisMenu;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbAracTuru;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.DataGridView dgvAraclar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panelToplam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamArac;
        private System.Windows.Forms.Panel panellceride;
        private System.Windows.Forms.Panel panelIceride;
        private System.Windows.Forms.Label lblIceridekiArac;
        private System.Windows.Forms.Panel panelKazanc;
        private System.Windows.Forms.Label lblToplamKazanc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}

