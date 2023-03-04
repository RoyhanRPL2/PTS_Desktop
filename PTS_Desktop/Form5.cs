using BarcodeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace PTS_Desktop
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GCSPLIL\SQLEXPRESS;Initial Catalog=db_perpustakaan;Integrated Security=True;");
        string imageLocation = "";

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string sirkulas = "";
            bool isChecked = cbPinjam.Checked;
            if (isChecked)
                sirkulas = cbPinjam.Text;
            else
                sirkulas = cbKembali.Text;

            byte[] images = null;
            FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [tb_buku] set kode = '" + this.txtKode.Text + "', nama_pengunjung='" + this.txtNamaPengunjung.Text + "', genre_buku='" + this.cbxGenre.Text + "', nama_buku='" + this.cbxNamaBuku.Text + "', status='" + sirkulas + "', date='"+ date.Value.ToString() +"' ,gambar_buku=@images where kode='" + this.txtKode.Text + "'";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            con.Close();
            Form3 form3 = new Form3();
            form3.display_data();
            MessageBox.Show("Data Edit Sukses");
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            int width = (int)(pictureBox2.Width * 1.0);
            int height = (int)(pictureBox2.Height * 1.0);
            Image image = barcode.Encode(TYPE.CODE128, cbxNamaBuku.Text, Color.Black, Color.Transparent, width, height);
            pictureBox2.Image = image;
        }

        private void cbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxGenre.Text == "Komik")
            {
                cbxNamaBuku.Items.Clear();
                cbxNamaBuku.Items.Add("One Piece");
                cbxNamaBuku.Items.Add("Dragon Ball");
                cbxNamaBuku.Items.Add("Naruto");
                cbxNamaBuku.Text = cbxNamaBuku.Items[0].ToString();
            }
            else if (cbxGenre.Text == "Edukasi")
            {
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
    }
}
