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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(maskedTextBox1.Text) || string.IsNullOrWhiteSpace(maskedTextBox2.Text) || string.IsNullOrWhiteSpace(maskedTextBox3.Text)))
            {
                MessageBox.Show("SİPARİŞİNİZ ALINDI!");
                Form2 yon1 = new Form2();
                yon1.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("işlem başarısız ");
                
            }
        }
    }
}
