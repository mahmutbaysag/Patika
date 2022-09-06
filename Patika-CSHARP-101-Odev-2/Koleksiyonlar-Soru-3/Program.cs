using System;
using System.Collections;

ArrayList sonuclar = new ArrayList();
Char[] sesliler = {'a','e','ı','i','o','ö','u','ü'};

Console.Write("Cümle giriniz: ");
string cumle = Console.ReadLine();
Char[] harfler = cumle.Split("");

foreach(char i in harfler){
    foreach(char j in sesliler){
        sonuclar.Add(j);
    }
}

sonuclar.Sort();

foreach(char  c in sonuclar){
    Console.WriteLine(c);
}
