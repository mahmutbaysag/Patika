//Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulama
/*
Örnek: Input: Merhaba Umut Arya

Output: True False True
*/
Console.WriteLine("Metin giriniz: ");
string metin = Console.ReadLine();

string[] kelimeler = metin.Split(" ");

string sesliler = "aeıioöuü";

foreach(string kelime in kelimeler){
    bool kontrol=false;
    for(int i=1;i<kelime.Length;i++){
        if(!sesliler.Contains(kelime[i]) && !sesliler.Contains(kelime[i-1])){
            kontrol=true;
        }
    }
    if(kontrol==true){
        Console.Write("True ");
    }else{
        Console.Write("False ");
    }
}
