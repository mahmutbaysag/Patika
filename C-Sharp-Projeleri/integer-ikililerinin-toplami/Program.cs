

Console.WriteLine("Sayilari giriniz: ");
string inp = Console.ReadLine();

string[] sayilar = inp.Split(" ");

for(int i=0;i<sayilar.Length;i+=2){
    if(sayilar[i]==sayilar[i+1]){
        Console.Write((Math.Pow(int.Parse(sayilar[i])*2,2)).ToString()+" ");
    }else{
        Console.Write(int.Parse(sayilar[i])+int.Parse(sayilar[i+1])+" ");
    }
}