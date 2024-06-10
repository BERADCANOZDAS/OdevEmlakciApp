using OdevEmlakciLib;
using System.Security.Cryptography.X509Certificates;

namespace OdevEmlakciApp
{
    class Program
    {
        static List<Ev> evler = new List<Ev>();

        static void Main()
        {
            Console.WriteLine("Emlakçı Uygulamasına Hoş Geldiniz");
            Console.Write("Yeni Kiralık Ev Ekle - Yeni Satılık Ev Ekle - Kayıtlı Evleri Görüntüle(1/2/3): ");
            
            string secim = Console.ReadLine();

            if (secim.ToLower() == "1")
            {
                KiralikEvEkle();
            }
            else if (secim.ToLower() == "2")
            {
                SatilikEvEkle();
            }
            else if (secim.ToLower() == "3")
            {
               KayitliEvleriGoruntule();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
            }
            
            
        }
       
          static void KayitliEvleriGoruntule()
        {
            using(StreamReader str = new StreamReader(@"C:\Users\Berat\source\repos\OdevEmlakciApp\OdevEmlakciLib\evler\evler.txt"))
            {
                String yaz;
                yaz=str.ReadLine();
            }
        }
        
     
        static void SatilikEvEkle()
        {
            SatilikEv yeniev1= new SatilikEv();
            Console.Write("Semt yazınız: ");
            yeniev1.semt = Console.ReadLine();
            Console.Write("Metrekare giriniz:");
            yeniev1.Metrekare = int.Parse(Console.ReadLine());
            Console.Write("Odasayısı Giriniz");
            yeniev1.OdaSayisi = int.Parse(Console.ReadLine());
            Console.Write("Fiyat Giriniz:");
            yeniev1.Fiyat = int.Parse(Console.ReadLine());

            evler.Add(yeniev1);


            using (StreamWriter evler = new StreamWriter(@"C:\Users\Berat\source\repos\OdevEmlakciApp\OdevEmlakciLib\evler\evler.txt", true))
            {
                evler.WriteLine($"Satılık Ev  :  Semt:{yeniev1.semt} - m2:{yeniev1.Metrekare} - Odasayısı:{yeniev1.OdaSayisi} - Fiyat:{yeniev1.Fiyat} ");
            }


            Console.WriteLine("Yeni Satılık ev ilanı eklendi!");
        }

        static void KiralikEvEkle()
        {
            KiralikEv yeniEv = new KiralikEv();
            Console.WriteLine("Kiralik Evler");
            Console.Write("Semt yazınız: ");
            yeniEv.semt = Console.ReadLine();
            Console.Write("Metrekare giriniz:");
            yeniEv.Metrekare= int.Parse( Console.ReadLine() );
            Console.Write("Odasayısı Giriniz");
            yeniEv.OdaSayisi= int.Parse( Console.ReadLine() );     
            Console.Write("Kira Giriniz:");
            yeniEv.Kira = int.Parse( Console.ReadLine() );
            Console.Write("Depozito Giriniz:");
            yeniEv.Depozito= int.Parse( Console.ReadLine() );   

           

            evler.Add(yeniEv);

           
            using (StreamWriter evler = new StreamWriter(@"C:\Users\Berat\source\repos\OdevEmlakciApp\OdevEmlakciLib\evler\evler.txt", true))
            {
                evler.WriteLine($"Kiralık Ev  :  Semt:{yeniEv.semt} - m2:{yeniEv.Metrekare} - Odasayısı:{yeniEv.OdaSayisi} - Kira:{yeniEv.Kira} - Depozito:{yeniEv.Depozito}");
            }


            Console.WriteLine("Yeni kiralık ev ilanı eklendi!");
        }
    }
}