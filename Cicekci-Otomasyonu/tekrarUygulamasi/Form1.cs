namespace tekrarUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Adminella" && textBox2.Text == "Qwer1234")
            {
                Form2 anaEkran = new Form2();
                anaEkran.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Hatalı Giriş !");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
