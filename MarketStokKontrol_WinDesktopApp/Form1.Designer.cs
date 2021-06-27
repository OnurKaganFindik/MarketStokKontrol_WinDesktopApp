
namespace MarketStokKontrol_WinDesktopApp
{
    partial class Form1
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
            if (disposing)
            {
                con.Close();
            }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tviKategoriler = new System.Windows.Forms.TreeView();
            this.btnUrunDuzenle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnYeniUrun = new System.Windows.Forms.Button();
            this.btnKategoriDuzenle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnYeniKategori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvUrunler.Location = new System.Drawing.Point(230, 47);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.RowTemplate.Height = 60;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(532, 324);
            this.dgvUrunler.TabIndex = 3;
            this.dgvUrunler.SelectionChanged += new System.EventHandler(this.dgvUrunler_SelectionChanged);
            this.dgvUrunler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvUrunler_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UrunAd";
            this.Column2.HeaderText = "Ürün Adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BirimFiyat";
            this.Column3.HeaderText = "Birim Fiyatı (₺)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StokAdet";
            this.Column4.HeaderText = "Stok Adedi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Resim";
            this.Column5.HeaderText = "Ürün Görseli";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürünler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategoriler";
            // 
            // tviKategoriler
            // 
            this.tviKategoriler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tviKategoriler.Location = new System.Drawing.Point(13, 47);
            this.tviKategoriler.Name = "tviKategoriler";
            this.tviKategoriler.Size = new System.Drawing.Size(211, 325);
            this.tviKategoriler.TabIndex = 2;
            this.tviKategoriler.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tviKategoriler_AfterSelect);
            // 
            // btnUrunDuzenle
            // 
            this.btnUrunDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUrunDuzenle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunDuzenle.BackgroundImage")));
            this.btnUrunDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrunDuzenle.Location = new System.Drawing.Point(260, 378);
            this.btnUrunDuzenle.Name = "btnUrunDuzenle";
            this.btnUrunDuzenle.Size = new System.Drawing.Size(24, 24);
            this.btnUrunDuzenle.TabIndex = 8;
            this.btnUrunDuzenle.UseVisualStyleBackColor = true;
            this.btnUrunDuzenle.Click += new System.EventHandler(this.btnUrunDuzenle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUrunSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.BackgroundImage")));
            this.btnUrunSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrunSil.Location = new System.Drawing.Point(290, 378);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(24, 24);
            this.btnUrunSil.TabIndex = 9;
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnYeniUrun
            // 
            this.btnYeniUrun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnYeniUrun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYeniUrun.BackgroundImage")));
            this.btnYeniUrun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYeniUrun.Location = new System.Drawing.Point(230, 378);
            this.btnYeniUrun.Name = "btnYeniUrun";
            this.btnYeniUrun.Size = new System.Drawing.Size(24, 24);
            this.btnYeniUrun.TabIndex = 7;
            this.btnYeniUrun.UseVisualStyleBackColor = true;
            this.btnYeniUrun.Click += new System.EventHandler(this.btnYeniUrun_Click);
            // 
            // btnKategoriDuzenle
            // 
            this.btnKategoriDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKategoriDuzenle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKategoriDuzenle.BackgroundImage")));
            this.btnKategoriDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKategoriDuzenle.Location = new System.Drawing.Point(43, 378);
            this.btnKategoriDuzenle.Name = "btnKategoriDuzenle";
            this.btnKategoriDuzenle.Size = new System.Drawing.Size(24, 24);
            this.btnKategoriDuzenle.TabIndex = 5;
            this.btnKategoriDuzenle.UseVisualStyleBackColor = true;
            this.btnKategoriDuzenle.Click += new System.EventHandler(this.btnKategoriDuzenle_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKategoriSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKategoriSil.BackgroundImage")));
            this.btnKategoriSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKategoriSil.Location = new System.Drawing.Point(73, 378);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(24, 24);
            this.btnKategoriSil.TabIndex = 6;
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnYeniKategori
            // 
            this.btnYeniKategori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnYeniKategori.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYeniKategori.BackgroundImage")));
            this.btnYeniKategori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYeniKategori.Location = new System.Drawing.Point(13, 378);
            this.btnYeniKategori.Name = "btnYeniKategori";
            this.btnYeniKategori.Size = new System.Drawing.Size(24, 24);
            this.btnYeniKategori.TabIndex = 4;
            this.btnYeniKategori.UseVisualStyleBackColor = true;
            this.btnYeniKategori.Click += new System.EventHandler(this.btnYeniKategori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 421);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tviKategoriler);
            this.Controls.Add(this.btnUrunDuzenle);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnYeniUrun);
            this.Controls.Add(this.btnKategoriDuzenle);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.btnYeniKategori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Market Stok Takibi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tviKategoriler;
        private System.Windows.Forms.Button btnUrunDuzenle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnYeniUrun;
        private System.Windows.Forms.Button btnKategoriDuzenle;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnYeniKategori;
    }
}

