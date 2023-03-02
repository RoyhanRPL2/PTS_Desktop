using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PTS_Desktop
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            generateid();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GCSPLIL\SQLEXPRESS;Initial Catalog=db_perpustakaan;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
        string member_id = "";

        void generateid()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select count(*) from [tb_member]";
            int count = (int)cmd.ExecuteScalar();
 
            if (count == 0)
            {
                member_id = string.Format("Menu-{0:000000}", 1);
            }
            else
            {
                cmd.CommandText = "select TOP 1 member_id from [tb_member] ORDER BY member_id desc";
                string menu_last_id = (string)cmd.ExecuteScalar();
                int last_id = int.Parse(menu_last_id.Substring(7)) + 1;
                member_id = string.Format("Member-{0:000000}", last_id);
            }
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text; 

            string query = "SELECT * FROM tb_member WHERE member_username=@Username AND member_password=@Password";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            con.Open();
            SqlDataReader dr = command.ExecuteReader();
            

            if (dr.Read())
            {
                MessageBox.Show("credential has ben used");
            }
            else
            {
               
                con.Close();
                con.Open();

                cmd.CommandText = "INSERT INTO [tb_member] (member_id, member_username, member_email, member_password, member_address, member_phoneNumber) values('" + member_id + "','" + txtUsername.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "', '" + txtAlamat.Text + "', '" + txtTelepon.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                generateid();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                con.Close();
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDaftar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
