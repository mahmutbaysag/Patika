using System;
using System.Collections;


public class Voiting{
    public users kullanicilar = new users();

    public ArrayList oylar = new ArrayList();

    public string[] kategoriler = {"Film","Tech-Stack","Spor"};

    public void OyVer(int kategori){
        oylar.Add(kategori);
    }

    public void KategoriListele(){
        Console.WriteLine("Kategoriler");
        for(int i=0;i<3;i++){
            Console.WriteLine($"{i.ToString()} - {kategoriler[i]}");
        }
    }

    public void SonuclariListele(){
        Hashtable toplamlar = new Hashtable();
        foreach(int oy in oylar){
            if(toplamlar.ContainsKey(oy)){
                toplamlar[oy]=(int)toplamlar[oy]+1;
            }else{
                toplamlar.Add(oy,1);
            }
        }

        
        Console.WriteLine("Sonuçlar");
        Console.WriteLine("*****************");
        foreach(string ktg in kategoriler){
            int toplam =(int)toplamlar[Array.IndexOf(kategoriler,ktg)];
            double oran = 100/(toplamlar.Count/toplam);
            Console.WriteLine($"{ktg} - {toplam} Oy - %{oran.ToString()}");
        }
    }


}