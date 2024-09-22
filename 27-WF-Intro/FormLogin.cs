using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_WF_Intro
{
    public partial class FormLogin : Form
    {
        private List<string> kullaniciAdlari;
        public FormLogin()
        {
            InitializeComponent();
            txtKullaniciAdi.Text = "mail@mail.com";

            kullaniciAdlari = new List<string>();
            kullaniciAdlari.Add("admin@mail.com");
            kullaniciAdlari.Add("bilgeadam@mail.com");
            kullaniciAdlari.Add("yonetici@mail.com");
            kullaniciAdlari.Add("fatih@mail.com");
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //kullanici adi fatih@msn.com ve şifre 123 ise hoşgeldiniz. değilse kullanıcı adı veya şifre hatalı yazsın.

            string sifreCevap = "123";

            if (kullaniciAdlari.Contains(txtKullaniciAdi.Text) && txtKullaniciSifre.Text == sifreCevap)
            {
                //
                FormMessage yeniForm = new FormMessage();
                yeniForm.kullaniciAdi = txtKullaniciAdi.Text;
                yeniForm.KarsilamaMesajiniYaz();
                yeniForm.Show();

                //this.Close();
                this.Hide();//This hide bu formu gizler. Eğer Close dersek uygulama kapanır. Çünkü bu form ana formdur.


                //MessageBox.Show("Giriş İşlem Başarılı", "Giriş İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (chckbxBeniHatirla.Checked)
                {
                    //Seçili ise
                }
                else
                {
                    //Seçili değilse
                }
            }
            else
            {
                MessageBox.Show("Kullanici adi veya şifre hatalı", "Hatali Giriş", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void chckbxBeniHatirla_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxBeniHatirla.Checked)
            {
                txtKullaniciSifre.PasswordChar = '\0';
            }
            else
            {
                txtKullaniciSifre.PasswordChar = '*';
            }
        }
    }
}
