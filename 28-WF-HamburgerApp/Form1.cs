using System.Data;
using System.Diagnostics;

namespace _28_WF_HamburgerApp
{
    public partial class Form1 : Form
    {
        private List<NumericUpDown> numericUpDownList;
        private List<Label> labels;
        private List<double> fiyatlar;
        double toplam = 0;
        public Form1()
        {
            InitializeComponent();

            txtNot.ScrollBars = ScrollBars.Both;
            txtNot.MaxLength = 150;
            txtNot.Text = "Merhaba Dünya";
            txtNot.ReadOnly = false;

            linkLabel1.LinkColor = Color.Gold;
            linkLabel1.ActiveLinkColor = Color.Fuchsia;
            linkLabel1.VisitedLinkColor = Color.Red;

            numericUpDownList = new List<NumericUpDown>() { nmrcHamburger1, nmrcHamburger2, nmrcIcecek1, nmrcIcecek2, nmrcDiger1, nmrcDiger2 };

            List<string> yiyecekler = new List<string>() { "King Chicken", "Köfte Burger", "Kola", "Fanta", "Büyük Patates", "Orta Patetes" };
            fiyatlar = new List<double>() { 140, 170, 25, 25, 35, 30 };

            labels = new List<Label>() { lblHamburger1, lblHamburger2, lblIcecek1, lblIcecek2, lblDiger1, lblDiger2 };

            for (int i = 0; i < yiyecekler.Count; i++)
            {
                labels[i].Text = yiyecekler[i] + "-" + fiyatlar[i];
            }

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni Menu Acildi");
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            //Kulanıcıya yeni kayıt ekleme izni
            dataGridViewSiparisler.AllowUserToAddRows = true;
            dataGridViewSiparisler.AllowUserToDeleteRows = true;

            //Veriye tıklandığında satır seçimi sağlama.
            dataGridViewSiparisler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //dataGridViewSiparisler.ColumnCount = 5;
            //dataGridViewSiparisler.Columns[0].Name = "No";
            //dataGridViewSiparisler.Columns[1].Name = "Urun";
            //dataGridViewSiparisler.Columns[2].Name = "Adet";
            //dataGridViewSiparisler.Columns[3].Name = "Fiyat";
            //dataGridViewSiparisler.Columns[4].Name = "Tutar";

            //string[] row = new string[] { "1", "Hamburger", "2", "20", "40" };
            //dataGridViewSiparisler.Rows.Add(row);

            DataTable dt = new DataTable();
            dt.Columns.Add("No");
            dt.Columns.Add("Urun");
            dt.Columns.Add("Adet");
            dt.Columns.Add("Fiyat");
            dt.Columns.Add("Tutar");

            int say = 1;
            double toplam2 = 0;
            for (int i = 0; i < numericUpDownList.Count; i++)
            {
                if (numericUpDownList[i].Value > 0)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = say;
                    dr["Urun"] = labels[i].Text.Split('-')[0];
                    dr[2] = numericUpDownList[i].Value;
                    dr[3] = labels[i].Text.Split('-')[1];
                    dr["Tutar"] = (fiyatlar[i] * Convert.ToDouble(numericUpDownList[i].Value));
                    dt.Rows.Add(dr);
                    toplam2 += (fiyatlar[i] * Convert.ToDouble(numericUpDownList[i].Value));
                    say++;

                    panel1.Enabled = true;
                }
            }

            dataGridViewSiparisler.DataSource = dt;

            toplam = toplam2;
            ToplamHesapla();

        }

        private void ToplamHesapla()
        {
            lblToplam.Text = "Toplam Fiyat: " + toplam + " TL.";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                toplam = toplam * 0.90;
                ToplamHesapla();
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                toplam = toplam * 0.85;
                ToplamHesapla();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Selected");
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string secili = "";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                secili += checkedListBox1.CheckedItems[i].ToString() + ", ";
            }



            MessageBox.Show(secili);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            MessageBox.Show(comboBox1.SelectedText.ToString());
            MessageBox.Show(comboBox1.SelectedIndex.ToString());

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d/M/yyyy h:mm";
        }

        private void txtNot_TextChanged(object sender, EventArgs e)
        {
            int uzunluk = txtNot.Text.Length;
            if (uzunluk > 100)
            {
                label6.ForeColor = Color.Red;
            }
            else
            {
                label6.ForeColor = Color.Green;
            }
            label6.Text = uzunluk.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            //Process.Start("https://alkanfatih.com");
        }
    }
}
