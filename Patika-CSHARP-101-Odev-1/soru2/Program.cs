
/*
Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


*/


Console.Write("n sayısını giriniz: ");
int n = int.Parse(Console.ReadLine());
Console.Write("m sayısını giriniz: ");
int m = int.Parse(Console.ReadLine());

for(int i=1;i<=n;i++){
    Console.Write(i.ToString() + ". pozitif sayıyı giriniz: ");
    int sayi = int.Parse(Console.ReadLine());
    if(sayi==m || sayi%m==0){
        Console.WriteLine(sayi.ToString());
    }
}
