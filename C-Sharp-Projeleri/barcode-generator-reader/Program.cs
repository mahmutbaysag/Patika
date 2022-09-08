
tekrar:
Console.WriteLine("İşlem Seçiniz: ");
Console.WriteLine("1-Barcode oluştur");
Console.WriteLine("2-Barcode oku");
int secim = int.Parse(Console.ReadLine());

switch (secim)
{
    case 1: { generate(); } break;
    case 2: { barcoderead(); } break;
}

goto tekrar;

void generate()
{
    Console.WriteLine("Dönüştürülecek Bağlantı veya Metni giriniz: ");
    string metin = Console.ReadLine();
    Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
    var img = barcode.Draw(metin,60);
    img.Save("barkod.png");
    Console.WriteLine("Barkod Kaydedildi"); 
    System.Diagnostics.Process.Start("barkod.png");
}

void barcoderead()
{
    Console.WriteLine("Dönüştürülecek Bağlantı veya Metni giriniz: ");
    string metin = Console.ReadLine();
    string data = Spire.Barcode.BarcodeScanner.ScanOne(metin);
    Console.WriteLine($"Sonuç={data}");
}
