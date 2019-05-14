namespace wf_ADONet_OKUL
{
    partial class frmAnasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuAnasayfa = new System.Windows.Forms.MenuStrip();
            this.öğrenciİşleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmOgrenciKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmOdemeler = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmOgrenciSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSinifTanimalamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSinifTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSinifSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmOgretmenTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmOgretmenSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.branşlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmBransTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmBransSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciBelgesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıfListeleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnasayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnasayfa
            // 
            this.mnuAnasayfa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuAnasayfa.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAnasayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşleriToolStripMenuItem,
            this.mitmSinifTanimalamToolStripMenuItem,
            this.öğretmenlerToolStripMenuItem,
            this.branşlarToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.mitmCikis});
            this.mnuAnasayfa.Location = new System.Drawing.Point(0, 0);
            this.mnuAnasayfa.Name = "mnuAnasayfa";
            this.mnuAnasayfa.Size = new System.Drawing.Size(770, 29);
            this.mnuAnasayfa.TabIndex = 1;
            this.mnuAnasayfa.Text = "menuStrip1";
            // 
            // öğrenciİşleriToolStripMenuItem
            // 
            this.öğrenciİşleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmOgrenciKayit,
            this.mitmOdemeler,
            this.mitmOgrenciSorgulama});
            this.öğrenciİşleriToolStripMenuItem.Name = "öğrenciİşleriToolStripMenuItem";
            this.öğrenciİşleriToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.öğrenciİşleriToolStripMenuItem.Text = "&Öğrenci İşleri";
            // 
            // mitmOgrenciKayit
            // 
            this.mitmOgrenciKayit.Name = "mitmOgrenciKayit";
            this.mitmOgrenciKayit.Size = new System.Drawing.Size(215, 26);
            this.mitmOgrenciKayit.Text = "Öğrenci &Kayıt";
            this.mitmOgrenciKayit.Click += new System.EventHandler(this.mitmOgrenciKayit_Click);
            // 
            // mitmOdemeler
            // 
            this.mitmOdemeler.Name = "mitmOdemeler";
            this.mitmOdemeler.Size = new System.Drawing.Size(215, 26);
            this.mitmOdemeler.Text = "Ödeme &İşlemleri";
            // 
            // mitmOgrenciSorgulama
            // 
            this.mitmOgrenciSorgulama.Name = "mitmOgrenciSorgulama";
            this.mitmOgrenciSorgulama.Size = new System.Drawing.Size(215, 26);
            this.mitmOgrenciSorgulama.Text = "Öğrenci &Sorgulama";
            // 
            // mitmSinifTanimalamToolStripMenuItem
            // 
            this.mitmSinifTanimalamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmSinifTanimlama,
            this.mitmSinifSorgulama});
            this.mitmSinifTanimalamToolStripMenuItem.Name = "mitmSinifTanimalamToolStripMenuItem";
            this.mitmSinifTanimalamToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.mitmSinifTanimalamToolStripMenuItem.Text = "Sınıflar";
            // 
            // mitmSinifTanimlama
            // 
            this.mitmSinifTanimlama.Name = "mitmSinifTanimlama";
            this.mitmSinifTanimlama.Size = new System.Drawing.Size(192, 26);
            this.mitmSinifTanimlama.Text = "Sınıf &Tanımlama";
            // 
            // mitmSinifSorgulama
            // 
            this.mitmSinifSorgulama.Name = "mitmSinifSorgulama";
            this.mitmSinifSorgulama.Size = new System.Drawing.Size(192, 26);
            this.mitmSinifSorgulama.Text = "Sınıf &Sorgulama";
            // 
            // öğretmenlerToolStripMenuItem
            // 
            this.öğretmenlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmOgretmenTanimlama,
            this.mitmOgretmenSorgulama});
            this.öğretmenlerToolStripMenuItem.Name = "öğretmenlerToolStripMenuItem";
            this.öğretmenlerToolStripMenuItem.Size = new System.Drawing.Size(111, 25);
            this.öğretmenlerToolStripMenuItem.Text = "Öğre&tmenler";
            // 
            // mitmOgretmenTanimlama
            // 
            this.mitmOgretmenTanimlama.Name = "mitmOgretmenTanimlama";
            this.mitmOgretmenTanimlama.Size = new System.Drawing.Size(232, 26);
            this.mitmOgretmenTanimlama.Text = "Öğretmen &Tanımlama";
            // 
            // mitmOgretmenSorgulama
            // 
            this.mitmOgretmenSorgulama.Name = "mitmOgretmenSorgulama";
            this.mitmOgretmenSorgulama.Size = new System.Drawing.Size(232, 26);
            this.mitmOgretmenSorgulama.Text = "Öğretmen &Sorgulama";
            // 
            // branşlarToolStripMenuItem
            // 
            this.branşlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmBransTanimlama,
            this.mitmBransSorgulama});
            this.branşlarToolStripMenuItem.Name = "branşlarToolStripMenuItem";
            this.branşlarToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.branşlarToolStripMenuItem.Text = "&Branşlar";
            // 
            // mitmBransTanimlama
            // 
            this.mitmBransTanimlama.Name = "mitmBransTanimlama";
            this.mitmBransTanimlama.Size = new System.Drawing.Size(200, 26);
            this.mitmBransTanimlama.Text = "Branş &Tanımlama";
            // 
            // mitmBransSorgulama
            // 
            this.mitmBransSorgulama.Name = "mitmBransSorgulama";
            this.mitmBransSorgulama.Size = new System.Drawing.Size(200, 26);
            this.mitmBransSorgulama.Text = "Branş &Sorgulama";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciBelgesiToolStripMenuItem,
            this.sınıfListeleriToolStripMenuItem,
            this.ödemeListesiToolStripMenuItem,
            this.öğretmenListesiToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.raporlarToolStripMenuItem.Text = "&Raporlar";
            // 
            // öğrenciBelgesiToolStripMenuItem
            // 
            this.öğrenciBelgesiToolStripMenuItem.Name = "öğrenciBelgesiToolStripMenuItem";
            this.öğrenciBelgesiToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.öğrenciBelgesiToolStripMenuItem.Text = "Öğrenci Belgesi";
            // 
            // sınıfListeleriToolStripMenuItem
            // 
            this.sınıfListeleriToolStripMenuItem.Name = "sınıfListeleriToolStripMenuItem";
            this.sınıfListeleriToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.sınıfListeleriToolStripMenuItem.Text = "Sınıf Listeleri";
            // 
            // ödemeListesiToolStripMenuItem
            // 
            this.ödemeListesiToolStripMenuItem.Name = "ödemeListesiToolStripMenuItem";
            this.ödemeListesiToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.ödemeListesiToolStripMenuItem.Text = "Ödeme Listesi";
            // 
            // öğretmenListesiToolStripMenuItem
            // 
            this.öğretmenListesiToolStripMenuItem.Name = "öğretmenListesiToolStripMenuItem";
            this.öğretmenListesiToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.öğretmenListesiToolStripMenuItem.Text = "Öğretmen Listesi";
            // 
            // mitmCikis
            // 
            this.mitmCikis.Name = "mitmCikis";
            this.mitmCikis.Size = new System.Drawing.Size(55, 25);
            this.mitmCikis.Text = "&Çıkış";
            this.mitmCikis.Click += new System.EventHandler(this.mitmCikis_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 341);
            this.Controls.Add(this.mnuAnasayfa);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuAnasayfa;
            this.Name = "frmAnasayfa";
            this.Text = "Öğrenci Takibi Anasayfa İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.mnuAnasayfa.ResumeLayout(false);
            this.mnuAnasayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnasayfa;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmOgrenciKayit;
        private System.Windows.Forms.ToolStripMenuItem mitmOdemeler;
        private System.Windows.Forms.ToolStripMenuItem mitmOgrenciSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mitmSinifTanimalamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmSinifTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmSinifSorgulama;
        private System.Windows.Forms.ToolStripMenuItem öğretmenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmOgretmenTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmOgretmenSorgulama;
        private System.Windows.Forms.ToolStripMenuItem branşlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmBransTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmBransSorgulama;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciBelgesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıfListeleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmCikis;
    }
}