namespace _27_WF_Intro
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            lblBaslik = new Label();
            pictureBox1 = new PictureBox();
            lblKullanici = new Label();
            txtKullaniciAdi = new TextBox();
            lblKullaniciSifre = new Label();
            txtKullaniciSifre = new TextBox();
            chckbxBeniHatirla = new CheckBox();
            btnGiris = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaslik.Location = new Point(103, 56);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(78, 15);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "OTURUM AÇ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.Location = new Point(36, 195);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(76, 15);
            lblKullanici.TabIndex = 2;
            lblKullanici.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(36, 213);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(220, 23);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // lblKullaniciSifre
            // 
            lblKullaniciSifre.AutoSize = true;
            lblKullaniciSifre.Location = new Point(36, 262);
            lblKullaniciSifre.Name = "lblKullaniciSifre";
            lblKullaniciSifre.Size = new Size(81, 15);
            lblKullaniciSifre.TabIndex = 2;
            lblKullaniciSifre.Text = "Kullanıcı Şifre:";
            // 
            // txtKullaniciSifre
            // 
            txtKullaniciSifre.Location = new Point(36, 280);
            txtKullaniciSifre.Name = "txtKullaniciSifre";
            txtKullaniciSifre.PasswordChar = '*';
            txtKullaniciSifre.Size = new Size(220, 23);
            txtKullaniciSifre.TabIndex = 2;
            // 
            // chckbxBeniHatirla
            // 
            chckbxBeniHatirla.AutoSize = true;
            chckbxBeniHatirla.Location = new Point(36, 320);
            chckbxBeniHatirla.Name = "chckbxBeniHatirla";
            chckbxBeniHatirla.Size = new Size(86, 19);
            chckbxBeniHatirla.TabIndex = 3;
            chckbxBeniHatirla.Text = "Sifre Göster";
            chckbxBeniHatirla.UseVisualStyleBackColor = true;
            chckbxBeniHatirla.CheckedChanged += chckbxBeniHatirla_CheckedChanged;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(36, 367);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(220, 38);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 450);
            Controls.Add(btnGiris);
            Controls.Add(chckbxBeniHatirla);
            Controls.Add(txtKullaniciSifre);
            Controls.Add(lblKullaniciSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullanici);
            Controls.Add(pictureBox1);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            Text = "MSN Messenger";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private PictureBox pictureBox1;
        private Label lblKullanici;
        private TextBox txtKullaniciAdi;
        private Label lblKullaniciSifre;
        private TextBox txtKullaniciSifre;
        private CheckBox chckbxBeniHatirla;
        private Button btnGiris;
    }
}