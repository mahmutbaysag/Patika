

public class Islemler{

    public rehber r = new rehber();

    public Islemler(){
        for(int i=1;i<6;i++){
            this.r.KayitEkle(i.ToString()+".kisi","soyad","0555555555"+i.ToString());
        }
    }

    public void yeniKayit(){
        //yeni numara kaydet
        Console.Write("Lütfen isim giriniz               :");
        String isim = Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz            :");
        String soyisim = Console.ReadLine();
        Console.Write("Lütfen telefon numarasını giriniz :");
        String numara = Console.ReadLine();
        r.KayitEkle(isim,soyisim,numara);
        Console.WriteLine("Kayıt Eklendi");
        secenekListele();
    }

    public void kayitSil(){
         //varolan numarayı sil
        silmetekrar:
        Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
        string deger = Console.ReadLine();
        if(r.KayitSil(deger)){
            Console.Write(deger + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
            if(Console.ReadLine()=="y"){
                Console.WriteLine("Kayıt Silindi");
            }
        }else{
            Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            if(Console.ReadLine()=="2"){
                goto silmetekrar;
            }
        }
        secenekListele();
    }


    public void kayitGuncelle(){
        //varolan numarayı guncelle
        guncelletekrar:
        Console.WriteLine(" Lütfen numarasını guncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
        string ad = Console.ReadLine();
        Console.WriteLine("Yeni teleofn numarasını giriniz: ");
        string numara = Console.ReadLine();
        if(r.KayitGuncelle(ad,numara)){
            Console.WriteLine("İşlem Başarılı");
        }else{
            Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için           : (2)");
            if(Console.ReadLine()=="2"){
                goto guncelletekrar;
            }
        }
        secenekListele();
    }

    public void aramaYap(){
        //rehberde arama yap
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("********************************************** \n");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

        string secim = Console.ReadLine();
        switch(secim){
            case "1":
            {
                Console.Write("Arama yapmak istediğiniz kişinin ismi veya soyismini giriniz: ");
                r.rehberdeAra(Console.ReadLine(),1);
            }break;
            case "2":
            {
                Console.Write("Arama yapmak istediğiniz kişinin ismi veya soyismini giriniz: ");
                r.rehberdeAra(Console.ReadLine(),2);
            }break;
        }   
    }

    public void listele(){
        r.listele();
    }

    public void secenekListele(){
        string[] secenekler = {"Lütfen yapmak istediğiniz işlemi seçiniz :) ","*******************************************","(1) Yeni Numara Kaydetmek","(2) Varolan Numarayı Silmek","(3) Varolan Numarayı Güncelleme","(4) Rehberi Listelemek","(5) Rehberde Arama Yapmak"};
        foreach(string secenek in secenekler){
            Console.WriteLine(secenek);
        }
    }



}