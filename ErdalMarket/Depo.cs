using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdalMarket
{
    public class Depo
    {
        Urun[] urunler;

        public Depo()
        {
            urunler = new Urun[0];
        }

        public void Ekle(Urun eleman)
        {
            Urun[] gecici = new Urun[urunler.Length + 1];
            Array.Copy(urunler, gecici, urunler.Length);
            gecici[gecici.Length - 1] = eleman;
            urunler = gecici;
        }

        public void MenuYazdir()
        {
            for (int i = 0; i < urunler.Length; i++)
            {
               if (urunler[i].stok > 0)
                {
                    Console.WriteLine($"{i + 1} {urunler[i].isim}\t{urunler[i].fiyat} TL\t- Stok = {urunler[i].stok}");
                }
            }
        }

        public double FiyatGetir(int uruno)
        {
            double fiyat = urunler[uruno - 1].fiyat;
            return fiyat;
        }

        public double SatinAl(int uruno, int adet)
        {
            double fiyat = 0;
            if (urunler[uruno-1].stok >= adet)
            {
                fiyat = urunler[uruno - 1].fiyat;
                urunler[uruno - 1].stok -= adet;
            }
            else
            {
                Console.WriteLine("Stok Yetersiz");
            }
            return fiyat;
        }

        public string BirimGetir(int uruno)
        {
            return urunler[uruno - 1].birim;
        }
    }
}
