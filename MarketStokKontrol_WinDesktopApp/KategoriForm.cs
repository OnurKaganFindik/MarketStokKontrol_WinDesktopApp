using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStokKontrol_WinDesktopApp
{
    public partial class KategoriForm : Form
    {
        public int SonEklenenId { get; private set; }
        private readonly SqlConnection con;
        Kategori kategori;
        public KategoriForm(SqlConnection connection)
        {
            con = connection;
            InitializeComponent();
            KategorileriYukle();
        }

        private void KategorileriYukle()
        {
            var kategoriler = new List<Kategori>()
            {
                new Kategori(){KategoriAd="Mevcut değil"}
            };
            var cmd = new SqlCommand("SELECT Id, KategoriAd FROM Kategoriler ORDER BY KategoriAd", con);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kategoriler.Add(new Kategori()
                {
                    Id=(int)dr[0],
                    KategoriAd=(string)dr[1]
                });
            }
            dr.Close();
            cboUstKategori.DataSource = kategoriler;
        }

        public KategoriForm(SqlConnection connection,Kategori kategori):this(connection)
        {
            this.kategori = kategori;
            txtId.Text = kategori.Id.ToString();
            txtKategoriAd.Text = kategori.KategoriAd;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kategoriAd = txtKategoriAd.Text.Trim();
            if (kategoriAd == "")
            {
                MessageBox.Show("Önce bir kategori adı belirtmelisiniz.");
                return;
            }
            int ustKategoriId = (int)cboUstKategori.SelectedValue;

            //Yeni Kategori Ekleme
            if (kategori==null)
            {
                var cmd = new SqlCommand(
                   "INSERT INTO Kategoriler(KategoriAd, UstKategoriId) VALUES (@p1,@p2);", con
                    );
                cmd.Parameters.AddWithValue("@p1", kategoriAd);

                if (ustKategoriId == 0)
                    cmd.Parameters.AddWithValue("@p2", DBNull.Value);

                else
                    cmd.Parameters.AddWithValue("@p2", ustKategoriId);
                SonEklenenId = (int)(decimal)cmd.ExecuteScalar();
            }
            else
            {
                var cmd = new SqlCommand(
                    "UPDATE Kategoriler SET KategoriAd=@p1 WHERE Id=@p2", con);
                cmd.Parameters.AddWithValue("@p1", kategoriAd);
                cmd.Parameters.AddWithValue("@p2", kategori.Id);
                cmd.ExecuteNonQuery();
            }
            DialogResult = DialogResult.OK;
        }
    }
}
