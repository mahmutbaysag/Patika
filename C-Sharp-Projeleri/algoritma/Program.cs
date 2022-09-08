// Ekrandan bir string bir de sayı alan (aralarında virgül ile), ilgili string ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulası

Console.Write("Kelime ve sayı giriniz(aralarında virgül ile): ");
string data = Console.ReadLine();

string ndata ="";
for(int i=0;i<data.Split(",")[0].Length;i++){
    if(i!=int.Parse(data.Split(",")[1])-1){
        ndata+=data[i];
    }
}
Console.WriteLine(ndata);
Console.ReadKey();