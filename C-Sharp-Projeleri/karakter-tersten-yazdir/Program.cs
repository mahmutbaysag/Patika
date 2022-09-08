// Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulaması

Console.Write("Lütfen metin giriniz: ");
string metin = Console.ReadLine();

string tersten="";
for(int i=0;i<metin.Length;i++){
    tersten = metin[i]+tersten;
}
Console.Write(tersten);
Console.ReadKey();