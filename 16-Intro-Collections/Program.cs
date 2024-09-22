using System.Collections;
using System.Net.Http.Headers;

namespace _16_Intro_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Koleksiyonlar, genellikle veri toplamak, saklamak ve işlemek için kullanılan yapısal veri türleridir.
            //List, içersinde (<T>) bir yapı bulunur. (<T>) tipi temsil eder. Yani verilen tipe bürünerek o tipte bir koleksiyon oluşturmamıza olanak sağlar. Daha önceki diziler gibi boyut arttırma işlemine gerek duymadan istediğimiz kadar eleman ekleyip/çıkarabiliriz. Liste Generic bir yapıdır.


            List<string> liste = new List<string>() {"adasd", "dsadsad", "adsasd", "asdsad"};

            #region ListTanımla
            List<int> sayilar = new List<int>();
            sayilar.Add(2);
            sayilar.Add(20);
            sayilar.Add(30);
            sayilar.Add(4);

            List<string> sehirler = new List<string>() { "Istanbul", "Ankara", "Rize" };
            sehirler.Add("Bursa");
            sehirler.Add("Izmir");
            sehirler.Add("Tokat");

            //Elemanına erişim.
            Console.WriteLine(sehirler[2]);

            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            #endregion

            #region ListMetotlar

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);
            numbers.Add(60);

            //Eleman Silme
            numbers.Remove(20); //Değer Bazlı Silme
            numbers.RemoveAt(1); //Index Bazlı Silme
            numbers.RemoveRange(1, 2); //Aralık Bazlı Silme 

            //Eleman Ekleme
            numbers.Insert(2, 25); //Spesifik pozisyona öğe ekleme

            numbers.Count(); //Öğe sayısını

            //Contains (içermek)
            bool varMi = numbers.Contains(25);


            Console.WriteLine("");


            #endregion

            #region ArrayList
            //Şu zamana kadar gördüğümüz ilkel dizilerin en büyük iki özelliği
            //Tip Bağımlılığı ve Eleman Sayısı Zorunluluğu idi.

            //Ancak, ArrayList ile birlikte bu bağımlılıklar ortadan kalktı. ArrayList tanımlarken ne elemean sayısı nede tip vermek zorunda değiliz.

            //Dezavantaj
            //ArrayList içerisinde elemanları otomatik olarak Object tipie döndürme özelliğine sahip. Dolayısıyla verileri geri almak istediğimizde mecburen cast yada convert işlemine gerek duymaktasınız.

            //Ekstra iki kat iş

            ArrayList yeniDizi = new ArrayList();
            yeniDizi.Add("KD-21");
            yeniDizi.Add(16);
            yeniDizi.Add(true);
            yeniDizi.Add(new DateTime());

            foreach (var item in yeniDizi)
            {
                Console.WriteLine(item);
            }

            //TrimToSize
            yeniDizi.TrimToSize(); //O anki kapasiteyi eleman sayısına eşitleme...

            #endregion

            #region Dictionary<TKey, Value>
            //anahtar-değer çiftlerini içeren bir koleksiyondur. Anahtarlar benzersiz olmalı.
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("Fatih", 37);
            ages.Add("Yasin", 24);
            ages.Add("Furkan", 25);
            ages.Add("Onur", 36);

            Dictionary<int, bool> varOlanlar = new Dictionary<int, bool>();
            varOlanlar.Add(123, true);
            varOlanlar.Add(23, false);
            #endregion

            #region HashSet
            //Benzersiz öğeleri içerir.
            HashSet<int> sets = new HashSet<int>();
            sets.Add(10);
            sets.Add(20);
            sets.Add(10); //Görmezden gelinir.

            #endregion

            #region Queue
            //FIFO (First in First Out) mantığına göre çalışır. İlk eklene öğe ilk çıkarılan öğedir.
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);


            int yananNumara = queue.Dequeue();
            int yananNumara2 = queue.Peek(); //Sıranın başındaki bilgiyi almak için.

            #endregion

            #region Stack
            //LIFO (Last in First Out) En son eklenen ilk çıkar
            Stack<int> stack = new Stack<int>();
            stack.Push(2); //Listenin sonuna ekleme yapar.
            stack.Push(3);
            stack.Push(5);

            int oge1 = stack.Pop(); //Listenin en üstündeki öğeyi kaldırır ve döndür.
            #endregion

            #region SortedSet
            //Sıralı bir liste oluşturur.
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(30);
            sortedSet.Add(10);
            sortedSet.Add(20);
            #endregion

            Console.WriteLine("");
        }
    }
}
