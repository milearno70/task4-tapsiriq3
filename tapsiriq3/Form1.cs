
using System;
using System.Windows.Forms;

namespace tapsiriq3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnTopla.Click += btnTopla_Click;
        }

        private bool EdedleriYoxla(out int a, out int b)
        {
            bool duzgunA = int.TryParse(txtA.Text, out a);
            bool duzgunB = int.TryParse(txtB.Text, out b);

            if (!duzgunA || !duzgunB)
            {
                lblNetice.Text = "Düzgün ədədlər daxil edin!";
                return false;
            }

            return true;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            if (EdedleriYoxla(out int a, out int b))
                lblNetice.Text = "Nəticə: " + (a + b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EdedleriYoxla(out int a, out int b))
                lblNetice.Text = "Nəticə: " + (a - b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EdedleriYoxla(out int a, out int b))
                lblNetice.Text = "Nəticə: " + (a * b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!EdedleriYoxla(out int a, out int b))
                return;

            if (b == 0)
            {
                MessageBox.Show("Sıfıra bölmək olmaz!");
                lblNetice.Text = "Sıfıra bölmək olmaz!";
                return;
            }

            lblNetice.Text = "Nəticə: " + ((double)a / b);
        }

        private void textA_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
