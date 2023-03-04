
namespace PTS_Desktop
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaPengunjung = new System.Windows.Forms.TextBox();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.cbxNamaBuku = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPinjam = new System.Windows.Forms.CheckBox();
            this.cbKembali = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jenis Buku";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PTS_Desktop.Properties.Resources.addImage1;
            this.pictureBox1.Location = new System.Drawing.Point(618, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kode";
            // 
            // txtKode
            // 
            this.txtKode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKode.Location = new System.Drawing.Point(279, 36);
            this.txtKode.Multiline = true;
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(259, 40);
            this.txtKode.TabIndex = 10;
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(795, 398);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(139, 47);
            this.btnTambah.TabIndex = 11;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(667, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Browse Gambar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKembali.Location = new System.Drawing.Point(1072, 567);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(116, 38);
            this.btnKembali.TabIndex = 15;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nama Pengunjung";
            // 
            // txtNamaPengunjung
            // 
            this.txtNamaPengunjung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamaPengunjung.Location = new System.Drawing.Point(280, 104);
            this.txtNamaPengunjung.Multiline = true;
            this.txtNamaPengunjung.Name = "txtNamaPengunjung";
            this.txtNamaPengunjung.Size = new System.Drawing.Size(259, 40);
            this.txtNamaPengunjung.TabIndex = 17;
            // 
            // cbxGenre
            // 
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Items.AddRange(new object[] {
            "Komik",
            "Edukasi",
            "Novel"});
            this.cbxGenre.Location = new System.Drawing.Point(281, 177);
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(257, 34);
            this.cbxGenre.TabIndex = 20;
            this.cbxGenre.SelectedIndexChanged += new System.EventHandler(this.cbxGenre_SelectedIndexChanged);
            // 
            // cbxNamaBuku
            // 
            this.cbxNamaBuku.FormattingEnabled = true;
            this.cbxNamaBuku.Items.AddRange(new object[] {
            "One Piece",
            "Matematika Terpadu",
            "Bumi"});
            this.cbxNamaBuku.Location = new System.Drawing.Point(281, 246);
            this.cbxNamaBuku.Name = "cbxNamaBuku";
            this.cbxNamaBuku.Size = new System.Drawing.Size(258, 34);
            this.cbxNamaBuku.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 36);
            this.label4.TabIndex = 22;
            this.label4.Text = "Status";
            // 
            // cbPinjam
            // 
            this.cbPinjam.AutoSize = true;
            this.cbPinjam.Location = new System.Drawing.Point(285, 317);
            this.cbPinjam.Name = "cbPinjam";
            this.cbPinjam.Size = new System.Drawing.Size(86, 30);
            this.cbPinjam.TabIndex = 23;
            this.cbPinjam.Text = "Pinjam";
            this.cbPinjam.UseVisualStyleBackColor = true;
            // 
            // cbKembali
            // 
            this.cbKembali.AutoSize = true;
            this.cbKembali.Location = new System.Drawing.Point(389, 317);
            this.cbKembali.Name = "cbKembali";
            this.cbKembali.Size = new System.Drawing.Size(95, 30);
            this.cbKembali.TabIndex = 24;
            this.cbKembali.Text = "Kembali";
            this.cbKembali.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(54, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 36);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tanggal";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(284, 378);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(255, 30);
            this.date.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PTS_Desktop.Properties.Resources.addImage1;
            this.pictureBox2.Location = new System.Drawing.Point(952, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(310, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1002, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 42);
            this.button1.TabIndex = 28;
            this.button1.Text = "Barcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(952, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 47);
            this.button3.TabIndex = 29;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbKembali);
            this.panel1.Controls.Add(this.cbPinjam);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxNamaBuku);
            this.panel1.Controls.Add(this.cbxGenre);
            this.panel1.Controls.Add(this.txtNamaPengunjung);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnKembali);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnTambah);
            this.panel1.Controls.Add(this.txtKode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(58, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 705);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(58, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 65);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tambah Data";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1416, 885);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaPengunjung;
        private System.Windows.Forms.ComboBox cbxGenre;
        private System.Windows.Forms.ComboBox cbxNamaBuku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbPinjam;
        private System.Windows.Forms.CheckBox cbKembali;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}