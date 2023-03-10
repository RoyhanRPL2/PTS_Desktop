using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PTS_Desktop
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GCSPLIL\SQLEXPRESS;Initial Catalog=db_perpustakaan;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string query = "SELECT COUNT(*) FROM tb_member WHERE member_username=@Username AND member_password=@Password";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            con.Open();
            int count = (int)command.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = MessageBox.Show("maybe you dont have account want to sign up", "signup", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                else
                {

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to leave?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //Do something
            }
        }
    }
}
