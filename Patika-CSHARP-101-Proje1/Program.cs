using System;

namespace TelefonRehberi
{
    class Program{
        static void Main(string[] args){
            
            Islemler islem = new Islemler();

            tekrar:
            islem.secenekListele();
            
            int secili = int.Parse(Console.ReadLine());
            switch(secili){
                case 1:
                    {
                        
                        islem.yeniKayit();
                    }
                    break;
                case 2:
                    {   
                       islem.kayitSil();
                    }
                    break;
                case 3:
                    {
                        islem.kayitGuncelle();
                    }
                    break;
                case 4:
                    {
                        //rehberi listele

                        islem.listele();
                    }
                    break;
                case 5:
                    {
                        islem.aramaYap();
                    }
                    break;
                default:{
                    Console.WriteLine("Hatalı Seçim Yaptınız");
                    }break;
            }
            goto tekrar;
        }

        
    }

}


