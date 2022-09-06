public class Card{

    private string title;
    public string Title{
        get{ return title;}
        set{ title = value;}
    }
    private string content;
    public string Content{
        get{ return content;}
        set{ content = value;}
    }
    private int size;
    public int Size{
        get{ return size;}
        set{ size = value;}
    }
    private int userid;
    public int Userid{
        get{ return userid;}
        set{ userid = value;}
    }

    public Card(string title,string content,int size,int userid){
        this.Title = title;
        this.Content = content;
        this.Size = size;
        this.Userid = userid;
    }

    public void Guncelle(string content,int size,int userid){
        this.Content= content;
        this.Size=size;
        this.Userid=userid;
    }

}