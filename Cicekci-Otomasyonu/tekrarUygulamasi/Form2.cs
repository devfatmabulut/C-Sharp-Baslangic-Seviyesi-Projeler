using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekrarUygulamasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGul_Click(object sender, EventArgs e)
        {
            listBoxCicek.Items.Add("Gül");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = checkBox1.Text;
            label3.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {   //sipariş görüntüle butonu
            listBoxRenk.Items.Add(label3.Text);
            listBoxBoyut.Items.Add(comboBox1.Text);
        }

        private void buttonLale_Click(object sender, EventArgs e)
        {
            listBoxCicek.Items.Add("Lale");
        }

        private void buttonMenekse_Click(object sender, EventArgs e)
        {
            listBoxCicek.Items.Add("Menekşe");
        }

        private void buttonOrkide_Click(object sender, EventArgs e)
        {
            listBoxCicek.Items.Add("Orkide");
        }

        private void buttonZambak_Click(object sender, EventArgs e)
        {
            listBoxCicek.Items.Add("Zambak");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = checkBox2.Text;
            label3.Visible = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = checkBox4.Text;
            label3.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = checkBox3.Text;
            label3.Visible = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = checkBox5.Text;
            label3.Visible = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = checkBox6.Text;
            label3.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 odeme = new Form3();
            odeme.Show();
            this.Hide();
        }
    }
}
