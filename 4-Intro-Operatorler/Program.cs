namespace _4_Intro_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boxing-Unboxing 
            //değer (Value Type) türlerinin referans türlerine (Referance Type) dönüştürülme işlemine denir. Veya ilkel veri tipinin Object dönüştürülmesi.

            //Boxing int, char, double, v.b value type'ların (object, string v.b) nesne türüne dönüştürme işlemidir.

            int intValue = 53;
            object boxedValue = intValue;

            //Unboxing bir referans türünden değer türüne dönüşüm işlemi.

            int intValue2 = (int)boxedValue;

            //Sık sık yapılan boxing ve unboxing işlemleri bellek tahsisi ve tip dönüşümleri gibi performansları olumsuz etikler.

            #region Deger(Value)Referans(Reference)Tipler(Type)

            //C# dilinde Tipler, değer tip (value type) ve referance type olmak üzere iki ana katagoriye ayrılır.

            //Değer Type (Value Type)
            // -int, -double, -char, -bool

            //Reference Type 
            // -string, -class, -interface, -delegaetei -record

            int a;
            a = 21;
            a = 25;
            //int a1 = null;

            string b;
            b = "Merhaba Dünya";
            b = "Fatih Alkan";
            string b1 = null;

            //Referans türü değişkenler bellekte veri için daha az yer kaplar ancak veriye erişim maliyete daha yüksek olur.

            Console.WriteLine(b);

            Console.WriteLine(a);

            #endregion


            //Operatörler
            #region AritmatikOperatörler
            //Matematiksel işlemleri gerçekleştirdiğimiz operatörlerdir. Toplam(+), Çıkarma(-), Çarpma(*), Bölme(/) Mod(%) temsil edilir.

            //int a = 5;
            //int b = 3;

            //Escape Squence
            //Console.WriteLine($"A Çarpı \n\t B: {a*b}");

            //= (Atama) Operatörü

            short x = 23;
            short y = 24;
            int z = (x + y);
            string adi = "fatih";
            #endregion

            #region Birleştirme(+)
            string deger1 = "Fatih";
            int deger2 = 34;
            Console.WriteLine(deger1+deger2);
            #endregion

            #region BirlesikAtama

            //int a1 = 10;
            //Console.WriteLine("a1: " + a1);
            
            //a1 = a1 + 5;
            //Console.WriteLine("a1: " + a1 );

            //int b1 = 15;
            //Console.WriteLine("b1: " + b1);
            
            //b1 += 5;
            //Console.WriteLine("b1: " + b1);

            //int c1 = 20;
            //Console.WriteLine("c1: " + c1);

            //c1 -= 10;
            //Console.WriteLine("c1: " + c1);

            // sayi += 2 , sayi -= 2 , sayi *= 2, sayi /= 2 

            #endregion

            #region ArtırmaAzaltma

            int sayi1 = 30;
            sayi1 = sayi1 + 1;
            sayi1 += 1;

            Console.WriteLine("sayi1: " + sayi1);

            ++sayi1;

            Console.WriteLine("sayi1: " + sayi1);


            //Sayıyı bir artırma
            int sayi2 = 15;
            Console.WriteLine("sayi2: " + (sayi2--));
            Console.WriteLine("sayi2: " + sayi2);

            //++degisken, önce değişkeni artırır sonra işlem yapar. degisken++ önce işlemi yapar sonra değeri artırır.

            #endregion

            #region EşitlikOperatörü

            int x1 = 5;
            int y1 = 5;

            Console.WriteLine(x1 == y1);
            Console.WriteLine(x1 != y1);

            #endregion

            #region KarşılaştırmaOperatörü

            int x3 = 5;
            int y3 = 10;

            bool buyukMu = x3 >= y3;

            //buyuk >, kucuk <, buyuk eşit >= kucuk eşit <= 

            #endregion

            #region KoşulOperatörü

            //&& (ve operatörü) (AND) -> Her iki koşulunda sağlandığı durumda çalışır.

            //|| (veya operatörü) (OR) -> Her iki koşuldan biri sağlandığı durumda çalışır.

            Console.WriteLine(false || true);

            Console.WriteLine(false && true);

            Console.WriteLine(false | true);

            Console.WriteLine(false & true);

            #endregion

            Console.WriteLine("Merhaba");
        }
    }
}
