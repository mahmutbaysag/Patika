// Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulama

static double fib(int s){
    if(s==0 || s==1){ return 1;}
    else{ return fib(s-1) + fib(s);}
}

Console.WriteLine("Derinlik Miktaırnı Giriniz: ");
int derinlik = int.Parse(Console.ReadLine());

double ort = 0;
double top=0;
for(int i=0;i<derinlik;i++){
    top += fib(i);
}

ort = top / derinlik;
Console.Write($"Ortalama={ort.ToString()}");

Console.ReadKey();