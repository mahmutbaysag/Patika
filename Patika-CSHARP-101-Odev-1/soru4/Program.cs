/*
Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

*/


Console.Write("Bir cümle yazınız: ");
string cumle = Console.ReadLine();

cumle = cumle.Replace(" ","");
int sayac = 0;
for(int i=0;i<cumle.Length;i++){
    if(Char.IsLetter(cumle[i])){
        sayac++;
    }
}

Console.WriteLine("Kelime Sayısı = ", cumle.Split(" ").Count().ToString());
Console.WriteLine("Harf Sayısı = ", sayac);