using System.DirectoryServices;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MemberApp
{
    public partial class Form1 : Form
    {
        private isUsers userManager;

        public Form1()
        {
            InitializeComponent();
            userManager = new isUsers();
            userManager.AddUser("admin", "admin");
        }

        // Bu yapýcý metod, isUsers nesnesini alýr
        public Form1(isUsers manager)
        {
            InitializeComponent();
            userManager = manager;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 0; button3.FlatAppearance.BorderSize = 0;

        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(60, 68, 83);
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(39, 47, 57);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(8, 133, 114);
            panel7.BackColor = Color.FromArgb(60, 68, 83);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.WhiteSmoke;
            panel7.BackColor = Color.FromArgb(39, 47, 57);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(60, 68, 83);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(39, 47, 57);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(userManager);
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(userManager);
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(userManager);
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!IsValidEmail(textBox1.Text))
            {
                label17.Visible = true;
            }

            if (textBox2.Text.Length < 3)
            {
                label19.Visible = true;
            }

            if (textBox1.Text == "" || textBox2.Text == "") return;

            if (userManager.IsUserRegistered(textBox1.Text, textBox2.Text))
            {
                Form3 form3 = new Form3(userManager);
                this.Hide();
                form3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("E-posta veya þifre hatalý!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Regex pattern for validating email
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(textBox1.Text))
            {
                label17.Visible = false;
                label13.ForeColor = Color.Green;
            }
            else
            {
                label13.ForeColor = Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 3)
            {
                label19.Visible = false;
                label14.ForeColor = Color.Green;
            }
            else
            {
                label14.ForeColor = Color.Red;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }
    }
}