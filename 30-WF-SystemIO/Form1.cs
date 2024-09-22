namespace _30_WF_SystemIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //StreamReader ve StreamWriter
        }

        //Klasör Oluşturma
        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = Directory.CreateDirectory(@"C:\Users\fatih.alkan\Desktop\NewKD21");

            MessageBox.Show(info.FullName);
        }

        //Klasör Silme ve Exists
        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Users\fatih.alkan\Desktop\NewKD21"))
            {
                Directory.Delete(@"C:\Users\fatih.alkan\Desktop\NewKD21");
            }
            else
            {
                MessageBox.Show("Dosya Bulunamadı...");
            }
        }

        //Klasör Taşıma
        private void button3_Click(object sender, EventArgs e)
        {
            Directory.Move(@"C:\Users\fatih.alkan\Desktop\NewKD21", @"C:\Users\fatih.alkan\Desktop\KD-21\NewKD21");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DirectoryInfo fi = new DirectoryInfo(@"C:\Users\fatih.alkan\Desktop\NewKD21");

            string message = $"Klasör Adı: {fi.Name} \nKlasör Oluşma Tarihi: {fi.CreationTime.ToShortDateString()} \nSon Erişim Tarihi: {fi.LastAccessTime} \nYazılma Tarihi: {fi.LastWriteTime} \nKök Dizini: {fi.Root}";

            MessageBox.Show(message);
        }

        //Dosya Oluşturma
        private void button5_Click(object sender, EventArgs e)
        {
            File.Create(@"C:\Users\fatih.alkan\Desktop\NewKD21\new.txt");
            //File.Copy("varOlanAdres","kopyalanacakAdres") --> Kopyalama
            //File.Delete("adres") --> Silme
            //File.Exists("adres") --> Varmi?
            //File.Move("varOlanAdres","taşınacakAdres);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Satır Satır Yazma
            //List<string> isimler = new List<string> { "Yasin", "Onur", "Merve" };
            //File.WriteAllLines(@"C:\Users\fatih.alkan\Desktop\NewKD21\new.txt", isimler);

            File.WriteAllText(@"C:\Users\fatih.alkan\Desktop\NewKD21\new.txt", "Merhaba Dünya benim adım \n\tfatih");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Tüm dosyayı okur
            //string info = File.ReadAllText(@"C:\Users\fatih.alkan\Desktop\NewKD21\new.txt");
            //MessageBox.Show(info);

            //Satır satır okur
            string[] radline = File.ReadAllLines(@"C:\Users\fatih.alkan\Desktop\NewKD21\new.txt");

            foreach (var item in radline)
            {
                MessageBox.Show(item);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\fatih.alkan\Desktop\NewKD21\new.txt");
            string message = $"Varmi: {fileInfo.Exists}\nOluşturma Tarihi: {fileInfo.CreationTime}\nTam Adı:{fileInfo.FullName}";

            MessageBox.Show(message);
        }

        //Sürücü Bilgileri
        private void button9_Click(object sender, EventArgs e)
        {
            DriveInfo driveInfo = new DriveInfo("C");

            string message = $"Kullanılabilir Alanı: {driveInfo.AvailableFreeSpace} \nToplam Boş Alan: {driveInfo.TotalFreeSpace} \nToplam Boyut: {driveInfo.TotalSize}";

            MessageBox.Show(message);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\fatih.alkan\Desktop\NewKD21\new.txt";

            string fileName = Path.GetFileName(path);
            string dirName = Path.GetDirectoryName(path);
            string fullPath = Path.GetFullPath(path);
            string extension = Path.GetExtension(path);

            string newExtension = ".csv";
            string newPath = Path.ChangeExtension(path, newExtension);

        }
    }
}
