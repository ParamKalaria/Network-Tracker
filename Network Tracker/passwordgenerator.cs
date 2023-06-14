using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_King
{
    public partial class passwordgenerator : Form
    {
        public passwordgenerator()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(passwordlengthtextBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = (int)numericUpDown1.Value;

            string password = GetRandomPassword(length);

            passwordlengthtextBox2.Text = password;

        }

        public static string GetRandomPassword(int length)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            const string cb1charsNO = "0123456789";
            const string cb2charsA = "abcdefghijklmnopqrstuvwxyz";
            const string cb3charsa = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";         


            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        private void passwordgenerator_Load(object sender, EventArgs e)
        {

        }
    }
}
