Console.WriteLine("Çalışan Sayısı = {0} ",Calisan.CalisanSayisi);
Calisan Calisan1 = new Calisan("Adamın","Biri","IT");
Console.WriteLine("Çalışan Sayısı = {0} ",Calisan.CalisanSayisi);
Calisan Calisan2 = new Calisan("Adamın","Diğeri","IT");
Console.WriteLine("Çalışan Sayısı = {0} ",Calisan.CalisanSayisi);


Console.WriteLine("Toplama İşlemi Sonucu = {0}",Islemler.Topla(100,200));  
Console.WriteLine("Çıkarma İşlemi Sonucu = {0}",Islemler.Çıkar(400,150));


class Calisan 
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string Isim;
    private string Soyisim;

    private string Departman;

    static Calisan() //staticlerin erişim belirteçleri yoktur.
    {
        calisanSayisi = 0;
    }

    public Calisan(string ısim, string soyisim, string departman)
    {
        this.Isim = ısim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        calisanSayisi++;
    }

}

static class Islemler
{
    public static long Topla(int s1,int s2)
    {
        return s1 + s2;
    }    
    public static long Çıkar(int s1,int s2)
    {
        return s1 - s2;
    }
}