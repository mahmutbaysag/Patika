

Çalışan çalışan1 = new Çalışan();
çalışan1.ad = "Mahmut";
çalışan1.soyad = "Baysağ";
çalışan1.no = 1;
çalışan1.departman = "Yazılım Geliştirme";
çalışan1.ÇalışanBilgileri();

Console.WriteLine("---------------------");

Çalışan çalışan2 = new Çalışan();
çalışan2.ad = "Adamın";
çalışan2.soyad = "Biri";
çalışan2.no = 2;
çalışan2.departman = "Muhasebe";
çalışan2.ÇalışanBilgileri();    

class Çalışan
{

    public string ad;
    public string soyad;
    public int no;
    public string departman;

    public void ÇalışanBilgileri()
    {
        Console.WriteLine("Çalışan Adı= {0}",ad);
        Console.WriteLine("Çalışan Soyadı= {0}",soyad);
        Console.WriteLine("Çalışan Numarası= {0}",no);
        Console.WriteLine("Çalışan Departmanı= {0}",departman); 

    }
} 