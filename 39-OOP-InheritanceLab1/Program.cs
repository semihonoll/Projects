namespace _39_OOP_InheritanceLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone("AEG", "kablolu bağlantı");
            

            Console.WriteLine($"Markası: {phone1.Brand} Bağlantı Tipi: {phone1.ConnectionStatus()} Arama Yap: {phone1.Call()}");

            Phone phone2 = new Phone("AEG", "uydulu bağlantı");

            Console.WriteLine($"Markası: {phone2.Brand} Bağlantı Tipi: {phone2.ConnectionStatus()} Arama Yap: {phone2.Call()}");

            MobilPhone mobilPhone1 = new MobilPhone(true, true, "Nokia", "3G");
            Console.WriteLine($"Tipi: {mobilPhone1.PhoneType} Markasi: {mobilPhone1.Brand} Dokunmatik: {mobilPhone1.IsTouched} Kamera: {mobilPhone1.HasCamera} Bağlantı Tipi: {mobilPhone1.ConnectionStatus()} Arama Yap: {mobilPhone1.Call()}");


            SmartPhone smartPhone1 = new SmartPhone("Apple", "5G Bağlantı", true, true);

            Console.WriteLine($"Tipi: {smartPhone1.PhoneType} Markasi: {smartPhone1.Brand} Dokunmatik: {smartPhone1.IsTouched} Kamera: {smartPhone1.HasCamera} Ön Kamera: {smartPhone1.FrontCam} Bağlantı Tipi: {smartPhone1.ConnectionStatus()} Arama Yap: {smartPhone1.Call()}");


        }
    }
}
