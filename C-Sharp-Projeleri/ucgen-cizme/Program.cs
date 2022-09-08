// Kullanıcıdan alınan boyut bilgisine göre console'a Üçgen çizen uygulama
Console.WriteLine("Üçgen boyutu için sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());

for(int i=1;i<=sayi+1;i++){
    
    for(int j=1;j<i;j++)
    Console.Write("*");
    Console.WriteLine("");
    
}

Console.ReadKey();
