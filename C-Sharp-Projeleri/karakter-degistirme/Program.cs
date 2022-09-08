

Console.Write("Metni giriniz: ");
string metin = Console.ReadLine();

string[] parcala = metin.Split(" ");

foreach(string str in parcala){
    if(str.Length==1){
        Console.Write(str+" ");
    }else if(str.Length==2){
        string newstr="";
        newstr += str[str.Length-1];
        newstr += str[0];
        Console.Write(newstr+" ");
    }else{
        string newstr="";
        newstr += str[str.Length-1];
        newstr += str.Substring(1,str.Length-2);
        newstr += str[0];
        Console.Write(newstr+" ");
    }
}