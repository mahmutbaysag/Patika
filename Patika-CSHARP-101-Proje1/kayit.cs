

public class kayit{

    private string isim;
    public string Isim{
        get{ return isim;}
        set { isim = value;}
    }
    private string soyisim;
    public string Soyisim{
        get{ return soyisim;}
        set { soyisim = value;}
    }
    private string numara;
    public string Numara{
        get{ return numara;}
        set { numara = value;}
    }

    public kayit(string isim, string soyisim, string numara){
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Numara = numara;
    }

    public void Guncelle(string numara){
        this.Numara = numara;
    }
    
}