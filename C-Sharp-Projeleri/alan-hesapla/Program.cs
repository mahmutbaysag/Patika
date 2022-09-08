//alan hesabı



tekrar:
    secenekler();

void secenekler(){
    Console.WriteLine("İşlem yapılmak istenen şekli seçiniz");
    Console.WriteLine("1-Kare");
    Console.WriteLine("2-Dikdörtgen");
    Console.WriteLine("3-Üçgen");
    Console.WriteLine("4-Daire");

    int secenek = int.Parse(Console.ReadLine());

    Console.WriteLine("Hesaplanmak istenen boyutu seçiniz");
    Console.WriteLine("1-Çevre");
    Console.WriteLine("2-Alan");
    Console.WriteLine("3-Hacim");

    int boyut = int.Parse(Console.ReadLine());

    switch(secenek){
        case 1:{
            Kare(boyut);
        }break;
        case 2:{
            Dikdortgen(boyut);
        }break;
        case 3:{
            Ucgen(boyut);
        }break;
        case 4:{
            Daire(boyut);
        }break;
    }
    
}

void Kare(int boyut){
    Console.Write("Bir kenar uzunluğunu giriniz: ");
    int c = int.Parse(Console.ReadLine());
    switch(boyut){
        case 1:{
            Console.Write("Çevre="+(c*4).ToString());
        } break;
        case 2:{
            Console.Write("Alan="+(c*c).ToString());
        } break;
        case 3:{
            Console.Write((c*c*c).ToString());
        } break;
    }
}
void Dikdortgen(int boyut){
    Console.Write("Bir 1.kenar uzunluğunu giriniz: ");
    int c1 = int.Parse(Console.ReadLine());
    Console.Write("Bir 2.kenar uzunluğunu giriniz: ");
    int c2 = int.Parse(Console.ReadLine());
    switch(boyut){
        case 1:{
            Console.WriteLine("Çevre="+((c1*c2)/2).ToString());
        } break;
        case 2:{
            Console.WriteLine("Alan="+(c1*c2).ToString());
        } break;
        case 3:{
            Console.WriteLine("Hacim="+(c1*c1*c2).ToString());
        } break;
    }
}
void Ucgen(int boyut){
    
    switch(boyut){
        case 1:{
            Console.Write("Bir 1.kenar uzunluğunu giriniz: ");
            int c1 = int.Parse(Console.ReadLine());
            Console.Write("Bir 2.kenar uzunluğunu giriniz: ");
            int c2 = int.Parse(Console.ReadLine());
            Console.Write("Bir 3.kenar uzunluğunu giriniz: ");
            int c3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Çevre="+(c1+c2+c3).ToString());
        } break;
        case 2:{
            Console.Write("Taban kenar uzunluğunu giriniz: ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Yükseklik Giriniz: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Alan="+(t*h/2).ToString());
        } break;
        case 3:{
            Console.Write("Taban kenar uzunluğunu giriniz: ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Yükseklik Giriniz: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Prizma yüksekliği Giriniz: ");
            int ph = int.Parse(Console.ReadLine());
            Console.WriteLine("Hacim="+(t*h/2*ph).ToString());
        } break;
    }
}
void Daire(int boyut){
    Console.Write("Bir yarıçap uzunluğunu giriniz: ");
    int r = int.Parse(Console.ReadLine());
    switch(boyut){
        case 1:{
            Console.WriteLine("Çevre="+(2*Math.PI*r).ToString());
        } break;
        case 2:{
            Console.WriteLine("Alan="+(Math.Pow(r,2)*Math.PI).ToString());
        } break;
        case 3:{
            Console.WriteLine("Hacim="+(Math.Pow(r,3)*Math.PI*4/3).ToString());
        } break;
    }
}
