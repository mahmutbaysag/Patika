
Çalışan çalışan1 = new Çalışan("adamın","biri",1,"Muhasebe");
çalışan1.ÇalışanBilgileri();

Çalışan çalışan2 = new Çalışan();
çalışan2.Ad = "adamın";
çalışan2.Soyad = "diğeri";
çalışan2.No = 2;
çalışan2.Departman = "Başkan";
çalışan2.ÇalışanBilgileri();

Çalışan çalışan3 = new Çalışan("adamın","öbürü");
çalışan3.ÇalışanBilgileri();

class Çalışan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Çalışan(string ad, string soyad, int no,string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    public Çalışan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public Çalışan()
    {

    }

    public void ÇalışanBilgileri()
    {
        Console.WriteLine("Çalışan Adı= {0}",Ad);
        Console.WriteLine("Çalışan Soyadı= {0}",Soyad);
        Console.WriteLine("Çalışan Numarası= {0}",No);
        Console.WriteLine("Çalışan Departmanı= {0}",Departman); 

    }
}