using System;
using System.Collections;

Console.Write("Sayıları giriniz: ");
string data = Console.ReadLine();

string[] sayilar = data.Split(" ");

ArrayList kucukler= new ArrayList(),buyukler = new ArrayList();

for(int i=0;i<sayilar.Length;i++)
{
    if(int.Parse(sayilar[i])<67){
        kucukler.Add(sayilar[i]);
    }else{
        buyukler.Add(sayilar[i]);
    }
}

int farklar =0;

for(int i=0;i<kucukler.Count;i+=2){
    farklar += (int)kucukler[i] - (int)kucukler[i+1];
}

double kareler = 0;

for(int i=0; i<buyukler.Count;i+=2){
    kareler += Math.Pow(((int)buyukler[i]-(int)buyukler[i+1]),2);
}

