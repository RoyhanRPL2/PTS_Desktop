using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

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
            byte[] images = null;
            FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [tb_buku] (kode_buku,nama_buku,genre_buku,author_buku,publisher_buku,gambar_buku) values ('" + txtKode.Text.ToString() + "','" + txtNamaBuku.Text + "','" + txtGenreBuku.Text + "','" + txtAuthorBuku.Text + "','" + txtPublisherBuku.Text + "',@images)";
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
            byte[] images = null;
            FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [tb_buku] set kode_buku = '" + this.txtKode.Text.ToString() + "', nama_buku='" + this.txtNamaBuku.Text + "', genre_buku='" + this.txtGenreBuku.Text + "', author_buku='" + this.txtAuthorBuku.Text + "', publisher_buku='" + this.txtPublisherBuku.Text + "', gambar_buku=@images where kode_buku='" + this.txtKode.Text.ToString() + "'";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Edit Sukses");
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtKode.Text = "";
            txtNamaBuku.Text = "";
            txtGenreBuku.Text = "";
            txtAuthorBuku.Text = "";
            txtPublisherBuku.Text = "";
            pictureBox1.Image = Image.FromFile(@"C:\Users\ACER\source\repos\PTS_Desktop\PTS_Desktop\Resources\addImage1.png");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [tb_buku] where kode_buku = '" + txtKode.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            txtKode.Text = "";
            MessageBox.Show("Data Delete Sukses");
        }
    }
}
