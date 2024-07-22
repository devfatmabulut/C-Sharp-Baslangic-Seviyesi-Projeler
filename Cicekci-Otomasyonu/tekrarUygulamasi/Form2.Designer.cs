namespace tekrarUygulamasi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            buttonGul = new Button();
            buttonLale = new Button();
            buttonMenekse = new Button();
            buttonOrkide = new Button();
            buttonZambak = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            listBoxCicek = new ListBox();
            pictureBox1 = new PictureBox();
            listBoxRenk = new ListBox();
            listBoxBoyut = new ListBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonGul
            // 
            buttonGul.Location = new Point(17, 28);
            buttonGul.Name = "buttonGul";
            buttonGul.Size = new Size(90, 35);
            buttonGul.TabIndex = 0;
            buttonGul.Text = "Gül";
            buttonGul.UseVisualStyleBackColor = true;
            buttonGul.Click += buttonGul_Click;
            // 
            // buttonLale
            // 
            buttonLale.Location = new Point(17, 69);
            buttonLale.Name = "buttonLale";
            buttonLale.Size = new Size(90, 35);
            buttonLale.TabIndex = 1;
            buttonLale.Text = "Lale";
            buttonLale.UseVisualStyleBackColor = true;
            buttonLale.Click += buttonLale_Click;
            // 
            // buttonMenekse
            // 
            buttonMenekse.Location = new Point(17, 110);
            buttonMenekse.Name = "buttonMenekse";
            buttonMenekse.Size = new Size(90, 35);
            buttonMenekse.TabIndex = 2;
            buttonMenekse.Text = "Menekşe";
            buttonMenekse.UseVisualStyleBackColor = true;
            buttonMenekse.Click += buttonMenekse_Click;
            // 
            // buttonOrkide
            // 
            buttonOrkide.Location = new Point(17, 151);
            buttonOrkide.Name = "buttonOrkide";
            buttonOrkide.Size = new Size(90, 35);
            buttonOrkide.TabIndex = 3;
            buttonOrkide.Text = "Orkide";
            buttonOrkide.UseVisualStyleBackColor = true;
            buttonOrkide.Click += buttonOrkide_Click;
            // 
            // buttonZambak
            // 
            buttonZambak.Location = new Point(17, 192);
            buttonZambak.Name = "buttonZambak";
            buttonZambak.Size = new Size(90, 35);
            buttonZambak.TabIndex = 4;
            buttonZambak.Text = "Zambak";
            buttonZambak.UseVisualStyleBackColor = true;
            buttonZambak.Click += buttonZambak_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonGul);
            groupBox1.Controls.Add(buttonZambak);
            groupBox1.Controls.Add(buttonLale);
            groupBox1.Controls.Add(buttonOrkide);
            groupBox1.Controls.Add(buttonMenekse);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(129, 246);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÇİÇEKLER";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1 Adet", "Küçük Boy Buket ( 5 Adet )", "Orta Boy Buket ( 10 Adet )", "Büyük Boy Buket ( 20 Adet )" });
            comboBox1.Location = new Point(259, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(294, 29);
            comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 28);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 7;
            label1.Text = " Boyut Seçiniz";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(147, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 117);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Renk Seçiniz";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(268, 73);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(79, 25);
            checkBox6.TabIndex = 9;
            checkBox6.Text = "Pembe";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(155, 73);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(56, 25);
            checkBox5.TabIndex = 10;
            checkBox5.Text = "Sarı";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(268, 41);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(60, 25);
            checkBox4.TabIndex = 9;
            checkBox4.Text = "Mor";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(34, 73);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(64, 25);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "Mavi";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(155, 41);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(71, 25);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Beyaz";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(34, 41);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(78, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Kırmızı";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // listBoxCicek
            // 
            listBoxCicek.FormattingEnabled = true;
            listBoxCicek.ItemHeight = 21;
            listBoxCicek.Location = new Point(146, 212);
            listBoxCicek.Name = "listBoxCicek";
            listBoxCicek.Size = new Size(118, 46);
            listBoxCicek.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(569, -46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 360);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listBoxRenk
            // 
            listBoxRenk.FormattingEnabled = true;
            listBoxRenk.ItemHeight = 21;
            listBoxRenk.Location = new Point(271, 212);
            listBoxRenk.Name = "listBoxRenk";
            listBoxRenk.Size = new Size(87, 46);
            listBoxRenk.TabIndex = 11;
            // 
            // listBoxBoyut
            // 
            listBoxBoyut.FormattingEnabled = true;
            listBoxBoyut.ItemHeight = 21;
            listBoxBoyut.Location = new Point(364, 212);
            listBoxBoyut.Name = "listBoxBoyut";
            listBoxBoyut.Size = new Size(189, 46);
            listBoxBoyut.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 192);
            label2.Name = "label2";
            label2.Size = new Size(118, 17);
            label2.TabIndex = 13;
            label2.Text = "Sipariş Detayları : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 261);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 264);
            button1.Name = "button1";
            button1.Size = new Size(276, 36);
            button1.TabIndex = 15;
            button1.Text = "Siparişi Görüntüle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(294, 264);
            button2.Name = "button2";
            button2.Size = new Size(259, 36);
            button2.TabIndex = 16;
            button2.Text = "Ödeme Yap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 5);
            label4.Name = "label4";
            label4.Size = new Size(153, 14);
            label4.TabIndex = 11;
            label4.Text = "(Sadece 1 renk seçebilirsiniz.)";
            label4.Click += label4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(721, 312);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxBoyut);
            Controls.Add(listBoxRenk);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxCicek);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form2";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipariş Oluştur";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGul;
        private Button buttonLale;
        private Button buttonMenekse;
        private Button buttonOrkide;
        private Button buttonZambak;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox2;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ListBox listBoxCicek;
        private PictureBox pictureBox1;
        private ListBox listBoxRenk;
        private ListBox listBoxBoyut;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}