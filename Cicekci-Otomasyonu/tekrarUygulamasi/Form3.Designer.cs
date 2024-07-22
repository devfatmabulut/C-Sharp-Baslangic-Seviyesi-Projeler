namespace tekrarUygulamasi
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 0;
            label1.Text = "AD - SOYAD : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 29);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 2;
            label2.Text = "TELEFON : ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 117);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 158);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 4;
            label3.Text = "ADRES : ";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(122, 82);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(320, 29);
            maskedTextBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 490);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "İletişim Bilgileri";
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.Location = new Point(6, 421);
            button1.Name = "button1";
            button1.Size = new Size(494, 42);
            button1.TabIndex = 10;
            button1.Text = "Ödemeyi Tamamla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(maskedTextBox3);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Location = new Point(9, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 122);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 81);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 12;
            label6.Text = "CVV : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 81);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 11;
            label5.Text = "Son Kullanım Tarihi : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 26);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 9;
            label4.Text = "KART NUMARASI";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 10;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(169, 73);
            maskedTextBox3.Mask = "00/00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 29);
            maskedTextBox3.TabIndex = 9;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(145, 23);
            maskedTextBox2.Mask = "0000-0000-0000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(288, 29);
            maskedTextBox2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-52, 508);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(592, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(530, 669);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form3";
            ShowIcon = false;
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox1;
        private Panel panel1;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}