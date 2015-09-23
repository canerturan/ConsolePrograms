using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketModule;
namespace proje
{
    class Program
    {
        static void Main(string[] args)
        {
            var urunler = new Urunler();
            var kategori1 = new Kategori1() { };
            var kategori2 = new Kategori2() { };
            var yenir = new Yenebilir();
            var yenmez = new Yenemez();
            var meyve = new Meyveler();
            var sebze = new Sebzeler();
            var etler = new EtVeUrunleri();
            var sutler = new SutVeUrunleri();
            var tekel = new TekelUrunleri();
            

            int sayac1=0;
            int sayac2=0;
            int sayac3=0;
            int sayac4=0;
            
            Console.WriteLine("ürün girmek için lütfen Ekle yazınız. Fiyatlar için fiyat yazınız");
            


                if (Console.ReadLine() == "fiyat")
                {
                    Console.WriteLine("yenebilir mi ürün se Y ye yenemez ise Z ye basınız");
                    if (Console.ReadLine() == "Y")
                    {
                        Console.WriteLine("Yenebilir ürünler için satış fiyatımız ={0} TL", kategori1.UrunSatisFiyati);
                        Console.WriteLine("KDv oranımız={0}", kategori1.KDVHesapla());
                        double kar = kategori1.UrunSatisFiyati - kategori1.urunAlısFiyati;
                        Console.WriteLine("1 yenebilen için karımızı ={0} TL", kar);
                    }
                    else
                    {
                        Console.WriteLine("Yenemez ürünler için satış fiyatımız ={0} TL", kategori2.UrunSatisFiyati);
                        Console.WriteLine("KDv oranımız={0}", kategori2.KDVHesapla());
                        double kar1 = kategori2.UrunSatisFiyati - urunler.urunAlısFiyati;
                        Console.WriteLine("1 yenmeyen ürünler için karımızı ={0} Tl", kar1);
                    }

                    
                }






                else 
                {
                    Console.WriteLine("ürün eklemek isterseniz Y ye basınız Çıkmak farklı bir tuşa basınız");
                    if (Console.ReadLine() == "Y")
                    {


                        Console.WriteLine("Meyve eklemek için A ya basıp enterlaynız");
                        Console.WriteLine("Sebze eklemek için B ye basıp enterlaynız");
                        Console.WriteLine("Tekel ürünü eklemek için C ye basıp enterlaynız");
                        Console.WriteLine("Süt ürünü eklemek için D ye basıp enterlaynız");
                        string secenek = Console.ReadLine();
                        switch (secenek)
                        {
                            case "A":
                                {

                                    Console.WriteLine("kaç Meyve ekleyeceksiniz?");
                                    int adet1 = Convert.ToInt32(Console.ReadLine());
                                    string[] meyve1 = new string[adet1];
                                    for (int i = 1; i <= adet1; i++)
                                    {
                                        sayac1++;
                                        Console.WriteLine("{0} meyvemiz nedir?", i);
                                        string a = Console.ReadLine();
                                        Console.WriteLine("{0}. meyvemizin adı :{1}", i, a); continue;
                                    }
                                 
                                    break;

                                }

                            case "B":
                                {
                                    Console.WriteLine("kaç sebze ekleyeceksiniz?");
                                    int adet2 = Convert.ToInt32(Console.ReadLine());
                                    string[] sebze1 = new string[adet2];
                                    for (int i = 1; i <= adet2; i++)
                                    {
                                        sayac2++;
                                        Console.WriteLine("{0} sebzemiz nedir?", i);
                                        string a = Console.ReadLine();
                                        Console.WriteLine("{0}. sebzemizin adı :{1}", i, a); continue;
                                    }
                                   
                                    break;
                                }


                            case "C":
                                {
                                    Console.WriteLine("kaç Tekel ürünü ekleyeceksiniz?");
                                    int adet3 = Convert.ToInt32(Console.ReadLine());
                                    string[] tekel1 = new string[adet3];
                                    for (int i = 1; i <= adet3; i++)
                                    {
                                        sayac3++;
                                        Console.WriteLine("{0}. urun nedir?", i);
                                        string a = Console.ReadLine();
                                        Console.WriteLine("{0}. ürünümüzün adı :{1}", i, a);
                                        
                                        continue;
                                    }
                            
                                    break;

                                }

                            case "D":
                                {
                                    Console.WriteLine("kaç Süt ürünü ekleyeceksiniz?");
                                    int adet4 = Convert.ToInt32(Console.ReadLine());
                                    string[] tekel1 = new string[adet4];
                                    for (int i = 1; i <= adet4; i++)
                                    {
                                        sayac3++;
                                        Console.WriteLine("{0}. urun nedir?", i);
                                        string a = Console.ReadLine();
                                        Console.WriteLine("{0}. ürünümüzün adı :{1}", i, a); continue;
                                    }
                                    
                                    break;

                                }
                      
                        }
                        urunler.urunMiktari = sayac1 + sayac2 + sayac3 + sayac4;
                        Console.WriteLine("kaç ürünümüz oldu ={0}", urunler.urunMiktari);
                        Console.WriteLine("fiyatları görmek içi fiyat yazınız yoksa herhangi bir tuşa basınız.");
                        if (Console.ReadLine() == "fiyat")
                        {
                            Console.WriteLine("yenebilir mi ürün se Y ye yenemez ise Z ye basınız");
                            if (Console.ReadLine() == "Y")
                            {
                                Console.WriteLine("Yenebilir ürünler için satış fiyatımız ={0} TL", kategori1.UrunSatisFiyati);
                                Console.WriteLine("KDv oranımız={0}", kategori1.KDVHesapla());
                                double kar = kategori1.UrunSatisFiyati - kategori1.urunAlısFiyati;
                                Console.WriteLine("1 yenebilen ürünler için karımız ={0} TL", kar);
                            }
                            else if (Console.ReadLine() == "Z")
                            {
                                Console.WriteLine("Yenemez ürünler için satış fiyatımız ={0} TL", kategori2.UrunSatisFiyati);
                                Console.WriteLine("KDv oranımız={0}", kategori2.KDVHesapla());
                                double kar1 = kategori2.UrunSatisFiyati - urunler.urunAlısFiyati;
                                Console.WriteLine("1 yenmeyen ürünler için karımız ={0} TL", kar1);
                            }


                        }
                        else
                        {
                            Console.WriteLine("çıkış yapılıyor...bir tuşa basınız");
                            Console.ReadKey();

                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("çıkış yapılıyor...bir tuşa basınız");
                        Console.ReadKey();
                    
                    }

                }  

           
         

        }
        
        }
}
