using System;
using System.Collections;



ArrayList asal,asaln = new ArrayList();

for(int i=0;i<20;i++){
    Console.Write("Bir Sayı Giriniz: ");
    string oku = Console.ReadLine();
    if(Char.IsNumber(oku)){
        int sayi = int.Parse(sayi);
        if(sayi>=0){
            bool kontrol =true;
            for(int j=2;j<sayi;j++){
                if(sayi%j==0){
                    kontrol=false;
                }
            }
            if(kontrol){
                asal[i] = sayi;
            }else{
                asaln[i] = sayi;
            }
        }else{
            i--;
            Console.WriteLine("Lütfen negatif olmayan bir tamsayı giriniz");
        }
    }else{
        i--;
        Console.WriteLine("Lütfen negatif olmayan bir tamsayı giriniz");
    }
}

asal.Sort(); asal.Reverse();
asaln.Sort(); asaln.Reverse();

Console.WriteLine("Asal sayılar");
foreach(int i in asal){
    Console.WriteLine(i.ToString());
}

Console.WriteLine("Asal olmayan sayılar");
foreach(int i in asaln){
    Console.WriteLine(i.ToString());
}

double ort1,ort2;

foreach(int i in asal){
    ort1 += i/asal.Count;
}

foreach(int i in asaln){
    ort2 += i/asaln.Count;
}

Console.WriteLine("Asal sayılar eleman sayısı="+ asal.Count.ToString() +" ortalaması=" + ort1.ToString());
Console.WriteLine("Asal olmayan sayıların eleman sayısı="+ asaln.Count.ToString() +" ortalaması=" + ort2.ToString());






