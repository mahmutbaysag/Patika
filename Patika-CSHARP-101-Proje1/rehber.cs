using System;
using System.Collections;


public class rehber{

    public ArrayList kayitlar = new ArrayList();

    //yeni kayıt ekle
    public void KayitEkle(string isim,string soyisim, string numara){
        kayitlar.Add(new kayit(isim,soyisim,numara));
    }

    //numara sil
    public bool KayitSil(string deger){
        //ad veya soyad
        foreach(kayit k in kayitlar){
            if(k.Isim==deger || k.Soyisim==deger){
                kayitlar.Remove(k);
                return true;
            }
        }
        return false;
    }

    //numara güncelle
    public bool KayitGuncelle(string ad,string numara){
        //ad veya soyad
        foreach(kayit k in kayitlar){
            if(k.Isim==ad || k.Soyisim==ad){
                kayitlar[kayitlar.IndexOf(k)] = new kayit(k.Isim,k.Soyisim,numara);
                return true;
            }
        }
        return false; //numara bulunamadı
    }

    public void listele(){
        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine("*****************************************");
        foreach(kayit k in kayitlar){
            Console.WriteLine(k.Isim);
            Console.WriteLine(k.Soyisim);
            Console.WriteLine(k.Numara);
            Console.WriteLine("-");
        }
        if(kayitlar.Count==0){
            Console.WriteLine("Henüz Kayıt Bulunmamaktadır.");
        }
    }

    public void rehberdeAra(string deger,int tur){
        ArrayList sonuclar = new ArrayList();


        foreach(kayit k in kayitlar){
            if(tur==1){
                if(k.Isim==deger || k.Soyisim==deger){
                    sonuclar.Add(k);
                }
            }else{
                if(k.Numara==deger){
                    sonuclar.Add(k);
                }
            }
        }

        foreach(kayit k in sonuclar){
            Console.WriteLine("isim: "+k.Isim);
            Console.WriteLine("Soyisim: "+k.Soyisim);
            Console.WriteLine("Telefon Numarası: "+k.Numara);
            Console.WriteLine("-");
        }

        if(sonuclar.Count==0){
            Console.WriteLine("Kayıt Bulunamadı");
        }
    }


}