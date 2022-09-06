using System;

Console.Write("Lütfen pozitif bir tamsayı giriniz: ");
int n = int.Parse(Console.ReadLine());

int[] dizi = new int[n];
int count = 0;
while(n>0){
    Console.Write("Pozitif tam sayı giriniz: ");
    dizi[count] = int.Parse(Console.ReadLine());
    n--;
}

foreach(int i in dizi){
    Console.WriteLine(i.ToString());
}