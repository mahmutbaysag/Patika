Ogrenci Ogrenci1 = new Ogrenci();
Ogrenci1.Ismi = "Adamin";
Ogrenci1.Soyismi = "Biri";
Ogrenci1.Ogrno = 1;
Ogrenci1.Sinif = 1;
Ogrenci1.OgrenciBilgileriniGetir();

Ogrenci1.SinifDusur();
Ogrenci1.OgrenciBilgileriniGetir();

Ogrenci Ogrenci2 = new Ogrenci("Adamin","Digeri",2,1);
Ogrenci2.SinifAtlat();
Ogrenci2.OgrenciBilgileriniGetir();




class Ogrenci
{
    private string ismi;
    private string soyismi;
    private int ogrno;
    private int sinif;

    public string Ismi 
    {
        get {return ismi;}  
        set {ismi = value;} 
    }
    public string Soyismi { get => soyismi; set => soyismi = value; }
    public int Ogrno { get => ogrno; set => ogrno = value; }
    public int Sinif 
    { 
        get => sinif; 
        set
        {
            if(value<=1)
            {
                sinif = 1;
            }
            else
            {
                sinif = value;
            }
        }  
    }

    public Ogrenci(string ismi, string soyismi, int ogrno, int sinif)
    {
        Ismi = ismi;
        Soyismi = soyismi;
        Ogrno = ogrno;
        Sinif = sinif;
    }

    public Ogrenci(){}

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("********** Ogrenci Bilgieri **********");
        Console.WriteLine("Ogrenci Adi      = {0}",this.Ismi);
        Console.WriteLine("Ogrenci Soyismi  = {0}",this.Soyismi);
        Console.WriteLine("Ogrenci No       = {0}",this.Ogrno);
        Console.WriteLine("Ogrenci Sinifi   = {0}",this.Sinif);
    }

    public void SinifAtlat()
    {
        this.Sinif = this.Sinif + 1;
    }

    public void SinifDusur()
    {
        this.Sinif = this.Sinif - 1;
    }
}