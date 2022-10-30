using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdalMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Depo d = new Depo();
            double toplam = 0;


            #region Ürünleri Ekle

            Urun u = new Urun();
            u.isim = "Domates"; u.birim = "KG"; u.fiyat = 12.99; u.stok = 50;

            d.Ekle(u);

            Urun b = new Urun();
            b.isim = "Bezelye"; b.birim = "KG"; b.fiyat = 20; b.stok = 125;

            d.Ekle(b);

            Urun c = new Urun(){isim = "Patlıcan",birim = "KG",fiyat = 25,stok = 120};
            d.Ekle(c);

            d.Ekle(new Urun() { isim = "Doritos", birim = "Paket", fiyat = 15, stok = 50 });

            #endregion

            Console.WriteLine("Erdal Market'e Hoş Geldiniz");
            

            string secenek = "e";
            while (secenek == "e")
            {
                Console.WriteLine("Toplam = " + toplam + " TL");
                d.MenuYazdir();
                Console.WriteLine("Satın almak istediğiniz ürünün numarasını giriniz");
                int no = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Kaç {d.BirimGetir(no)} alacaksınız?");
                int adet = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(d.FiyatGetir(no) * adet + " TL");

                toplam += d.SatinAl(no,adet) * adet;
                Console.WriteLine("Alışverişe devam edilsin mi?e/h");
                secenek = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
