using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using BarcodeLib;

namespace PTS_Desktop
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GCSPLIL\SQLEXPRESS;Initial Catalog=db_perpustakaan;Integrated Security=True");
        string imageLocation = "";
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sirkulas = "";
            bool isChecked = cbPinjam.Checked;
            if (isChecked)
            {
                sirkulas = cbPinjam.Text;
                cbKembali.Checked = false;
            }
            else
            {
                sirkulas = cbKembali.Text;
                cbPinjam.Checked = false;
            }

            byte[] images = null;
            FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [tb_buku] (kode,nama_pengunjung,genre_buku,nama_buku,status,date,gambar_buku) values ('" + txtKode.Text + "','"+ txtNamaPengunjung.Text +"', '"+ cbxGenre.Text +"','"+ cbxNamaBuku.Text +"', '"+ sirkulas + "', '"+ date.Value.ToString() +"', @images)";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Disimpan");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All Files(*.*)|*.* ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imageLocation;
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           /* txtKode.Text = "";
            txtNamaBuku.Text = "";
            txtGenreBuku.Text = "";
            txtAuthorBuku.Text = "";
            txtPublisherBuku.Text = "";*/
            pictureBox1.Image = Image.FromFile(@"C:\Users\ACER\source\repos\PTS_Desktop\PTS_Desktop\Resources\addImage1.png");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            int width = (int)(pictureBox2.Width * 1.0);
            int height = (int)(pictureBox2.Height * 1.0);
            Image image = barcode.Encode(TYPE.CODE128, cbxNamaBuku.Text, Color.Black, Color.Transparent, width, height);
            pictureBox2.Image = image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtKode.Text = "";
            txtNamaPengunjung.Text = "";
            cbxGenre.Text = "";
            cbxNamaBuku.Text = "";
            cbPinjam.Checked = false;
            cbKembali.Checked = false;
            pictureBox1.Image = Image.FromFile(@"C:\Users\ACER\source\repos\PTS_Desktop\PTS_Desktop\Resources\addImage1.png"); ;
            pictureBox2.Image = Image.FromFile(@"C:\Users\ACER\source\repos\PTS_Desktop\PTS_Desktop\Resources\addImage1.png"); ;
        }

        private void cbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxGenre.Text == "Komik")
            {
                cbxNamaBuku.Items.Clear();
                cbxNamaBuku.Items.Add("One Piece");
                cbxNamaBuku.Text = cbxNamaBuku.Items[0].ToString();
            }
            else if (cbxGenre.Text == "Edukasi") {
                cbxNamaBuku.Items.Clear();
                cbxNamaBuku.Items.Add("Matematika");
                cbxNamaBuku.Items.Add("Ilmu Pengetahuan Alam");
                cbxNamaBuku.Items.Add("Ilmu Pengetahuan Sosial");
                cbxNamaBuku.Text = cbxNamaBuku.Items[0].ToString();
            }
            else if (cbxGenre.Text == "Novel")
            {
                cbxNamaBuku.Items.Clear();
                cbxNamaBuku.Items.Add("Bumi");
                cbxNamaBuku.Items.Add("Langit");
                cbxNamaBuku.Items.Add("Bintang");
                cbxNamaBuku.Text = cbxNamaBuku.Items[0].ToString();
            }
        }
    }
}
