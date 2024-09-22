namespace _29_WF_AdamAsmacaOyunu
{
    public partial class Form1 : Form
    {
        private string secilenKelime = "";
        private Label[] labels;
        int say = 0;
        public Form1()
        {
            InitializeComponent();

            pctrbxAdamAs.ImageLocation = @"..\..\..\Images\adamasmaca.png";
            pctrbxAdamAs.Load();

            LabelEkle();
            ButonEkle();
        }

        private void LabelEkle()
        {
            string[] kelimeler = new string[] { "TÜRKİYE", "AMERİKA", "RUSYA", "UGANDA", "KENYA", "ISPANYA", "ÇİN", "KORE", "JAPONYA", "ITALYA", "UKRAYNA", "SOMALİ" };

            Random rnd = new Random();
            secilenKelime = kelimeler[rnd.Next(kelimeler.Length)];

            labels = new Label[secilenKelime.Length];
            int x = 300, y = 70;

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl_" + secilenKelime[i];
                lbl.Text = "_";
                lbl.Font = new Font("Arial", 24, FontStyle.Bold);
                lbl.Size = new Size(40, 40);
                lbl.Location = new Point(x, y);
                this.Controls.Add(lbl);
                labels[i] = lbl;
                x += 40;
            }
        }
        private void ButonEkle()
        {
            string[] harfler = new string[] { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "W", "X", "Y", "Z" };

            int x = 0, y = 0;

            for (int i = 0; i < harfler.Length; i++)
            {
                Button btn = new Button();
                btn.Name = "btn_" + harfler[i];
                btn.Text = harfler[i];
                btn.Size = new Size(40, 40);
                btn.Click += new EventHandler(button_Click);

                if (i % 5 == 0)
                {
                    x = 40; y += 40;
                }
                else
                {
                    x += 40;
                }

                btn.Location = new Point(x, y);
                this.Controls.Add(btn);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            bool buldunMu = false;

            if (say <= 6)
            {
                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (btn.Text == secilenKelime[i].ToString())
                    {
                        labels[i].Text = btn.Text;
                        buldunMu = true;
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Oyunu Kaybettiniz!!!", "Game Over", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    //Yes olma durumu...
                }
                else if (result == DialogResult.No)
                {
                    //No olma durumu..
                }
                else if(result == DialogResult.Cancel)
                {
                    //Cancel olma durumu...
                }
            }

            if (buldunMu == false)
            {
                say++;
                AdamAs();
            }
        }

        private void AdamAs()
        {
            switch (say)
            {
                case 1:
                    pctrbxAdamAs.ImageLocation = @"..\..\..\Images\adamasmaca1.png";
                    pctrbxAdamAs.Load();
                    break;
                case 2:
                    pctrbxAdamAs.ImageLocation = @"..\..\..\Images\adamasmaca2.png";
                    pctrbxAdamAs.Load();
                    break;
                case 3:
                    pctrbxAdamAs.ImageLocation = @"..\..\..\Images\adamasmaca3.png";
                    pctrbxAdamAs.Load();
                    break;
                case 4:
                    pctrbxAdamAs.ImageLocation = @"..\..\..\Images\adamasmaca4.png";
                    pctrbxAdamAs.Load();
                    break;
                case 5:
                    pctrbxAdamAs.ImageLocation = @"..\..\..\Images\adamasmaca5.png";
                    pctrbxAdamAs.Load();
                    break;
                case 6:
                    pctrbxAdamAs.ImageLocation = @"..\..\..\Images\adamasmaca6.png";
                    pctrbxAdamAs.Load();
                    break;
                default:
                    break;
            }
        }
    }
}
