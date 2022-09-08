using atm_uygulamasi;
atm cihaz = new atm();

bastan:
Console.WriteLine("ATM ye hoşgeldiniz");
Console.WriteLine("******************");

try
{
    Console.WriteLine("1 - Kullanıcı İşlemleri");
    Console.WriteLine("2 - ATM İşlemleri");
    Console.WriteLine("İşlem Seçiniz:");
    string secim = Console.ReadLine();
    switch (secim)
    {
        case "1": 
            {
            tekrar:
                Console.Write("Lütfen Kimlik Numaranızı Giriniz: ");
                int identity = int.Parse(Console.ReadLine());
    
                if (cihaz.UserVarMi(identity))
                {
                    Console.WriteLine("İşlem Seçiniz");
                    Console.WriteLine("1 - Para Yatır");
                    Console.WriteLine("2 - Para Çek");
                    string islem = Console.ReadLine();
                    switch (islem)
                    {
                        case "1": 
                            {
                                Console.WriteLine(cihaz.ParaYatir(identity)?"İşlem Başarılı":"İşlem     Başarısız");
                            } 
                            break;
                        case "2": 
                            {
                                Console.WriteLine(cihaz.ParaCek(identity) ? "İşlem Başarılı":"İşlem     Başarısız");
                            } 
                            break;
                        default:
                            {
                                cihaz.logger.log(new Exception("Hatalı Kullanıcı İşlemi Seçimi"));
                            }
                            break;
                    }
                    goto tekrar;
                }
                else
                {
                    Console.WriteLine("Kullanıcı Bulunamadı. Tekrar Deneyiniz");
                    cihaz.logger.log(new Exception("Kullanıcı Bulunamadı."));
                    goto tekrar;
                }
            } break;
        case "2": 
            {
                Console.WriteLine("İşlem Seçiniz");
                Console.WriteLine("1 - Gün Sonu Oluştur");
                Console.WriteLine("2 - Gün Sonu Görüntüle");
                string islem = Console.ReadLine();
                switch (islem)
                {
                    case "1":
                        {
                            Console.WriteLine(cihaz.GunSonuOlustur() ? "İşlem Başarılı" : "İşlem Başarısız");
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine(cihaz.GunSonuGetir() ? "İşlem Başarılı" : "İşlem Başarısız");
                        }
                        break;
                    default :
                        {
                            cihaz.logger.log(new Exception("Hatalı ATM İşlemi Seçimi"));
                        }
                        break;
                }
                
            } 
            break;
        default:
            {
                cihaz.logger.log(new Exception("Hatalı Cihaz İşlemi Seçimi"));
            }
            break;
    }

}
catch (Exception err)
{
    cihaz.logger.log(err);
    goto bastan;
}


