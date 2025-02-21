using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberApp
{
    public partial class Form2 : Form
    {
        private isUsers userManager;

        public Form2(isUsers manager)
        {
            InitializeComponent();
            userManager = manager;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 0; button3.FlatAppearance.BorderSize = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label12.Text == "NaN" || (Int32.Parse(label12.Text) - 1) <= 0)
            {
                label11.Text = GenerateCaptcha();
                label12.Text = "60";
            }
            else
            {
                label12.Text = (Int32.Parse(label12.Text) - 1).ToString();
            }
        }

        public static string GenerateCaptcha()
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] captchaArray = new char[6];

            for (int i = 0; i < captchaArray.Length; i++)
            {
                captchaArray[i] = chars[random.Next(chars.Length)];
            }

            return new string(captchaArray);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isTrue = true;
            if (textBox5.Text != label11.Text)
            {
                label22.Visible = true;
                isTrue = false;
            }
            else
            {
                label22.Visible = false;
            }

            if (textBox6.Text.Length != 11)
            {
                label27.Visible = true;
                isTrue = false;
            }
            else
            {
                label17.Visible = false;
            }

            if (!IsFullName(textBox1.Text))
            {
                label17.Visible = true;
                isTrue = false;
            }
            else
            {
                label17.Visible = false;
            }

            if (!IsValidEmail(textBox2.Text))
            {
                label19.Visible = true;
                isTrue = false;
            }
            else
            {
                label19.Visible = false;
            }

            if (textBox3.Text.Length <= 3)
            {
                label23.Visible = false;
                label20.Visible = true;
                isTrue = false;
            }
            else
            {
                label23.Visible = true;
                label20.Visible = false;
            }

            if ((textBox3.Text != textBox4.Text) || (textBox3.Text.Length <= 3))
            {
                label21.Visible = true;
                isTrue = false;
            }
            else
            {
                label21.Visible = false;
            }

            if (isTrue)
            {
                if (userManager.IsUserRegistered(textBox2.Text, textBox3.Text))
                {
                    MessageBox.Show("Kullanıcı zaten kayıtlı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    userManager.AddUser(textBox2.Text, textBox3.Text);

                    Form1 form1 = new Form1(userManager);
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }

        public bool IsFullName(string value)
        {
            string[] parts = value.Trim().Split(' ');
            return parts.Length >= 2;
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
            if (IsFullName(textBox1.Text))
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
            if (IsValidEmail(textBox2.Text))
            {
                label19.Visible = false;
                label14.ForeColor = Color.Green;
            }
            else
            {
                label14.ForeColor = Color.Red;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 3)
            {
                label20.Visible = false;
                label15.ForeColor = Color.Red;
                label23.Visible = true;
                label23.Text = "Geçersiz.";
                label23.ForeColor = Color.Red;
            }
            else if ((textBox3.Text.Length == 3))
            {
                label20.Visible = false;
                label15.ForeColor = Color.Green;
                label23.Visible = true;
                label23.Text = "Zayıf.";
                label23.ForeColor = Color.Red;
            }
            else if ((textBox3.Text.Length > 3) && (textBox3.Text.Length < 7))
            {
                label20.Visible = false;
                label15.ForeColor = Color.Green;
                label23.Visible = true;
                label23.Text = "Orta.";
                label23.ForeColor = Color.Orange;
            }
            else if (textBox3.Text.Length >= 8)
            {
                label20.Visible = false;
                label15.ForeColor = Color.Green;
                label23.Visible = true;
                label23.Text = "Güçlü.";
                label23.ForeColor = Color.Green;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if ((textBox3.Text == textBox4.Text) && (textBox3.Text.Length >= 3))
            {
                label21.Visible = false;
                label16.ForeColor = Color.Green;
            }
            else
            {
                label16.ForeColor = Color.Red;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == label11.Text)
            {
                label22.Visible = false;
                label24.ForeColor = Color.Green;
            }
            else
            {
                label24.ForeColor = Color.Red;
            }
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(60, 68, 83);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(60, 68, 83);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(8, 133, 114);
            panel6.BackColor = Color.FromArgb(60, 68, 83);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.WhiteSmoke;
            panel6.BackColor = Color.FromArgb(39, 47, 57);
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(39, 47, 57);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(39, 47, 57);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userManager);
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userManager);
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userManager);
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.UseSystemPasswordChar)
            {
                textBox3.UseSystemPasswordChar = false;
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
                textBox4.UseSystemPasswordChar = true;
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length == 11)
            {
                label27.Visible = false;
                label28.ForeColor = Color.Green;
            }
            else
            {
                label28.ForeColor = Color.Red;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
