using System;
using System.Collections;

namespace Todo{
    public static class Program{
        public static void main(){

            Board board = new Board();

            Hashtable takim = new Hashtable();
            string[] uyeisimleri = {"adam","alex","casandra","lailo","jeremy"};
            for(int i=1;i<=uyeisimleri.Length;i++){
                takim.Add(i,uyeisimleri[i]);
            }

            tekrar:
            SecenekleriGetir();

            switch(Console.ReadLine()){
                case "1":
                    {
                        //listeleme
                        board.Listele();
                    }
                    break;
                case "2":
                    {
                        //kart ekle

                        //once user sonra line seçilmeli sonra bilgiler
                        

                        Console.WriteLine("Kolon Seçiniz (TODO,IN PROGRESS,DONE):");

                        string kolon = Console.ReadLine();

                        Console.WriteLine("Bilgileri Giriniz");
                        Console.WriteLine("Başlık Giriniz                                 :");
                        string title = Console.ReadLine();
                        Console.WriteLine("İçerik Giriniz                                 :");
                        string content = Console.ReadLine();
                        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
                        int size = int.Parse(Console.ReadLine());
                        Console.WriteLine("Kişi Seçiniz                                   :");
                        tekraruyesec:
                        Console.WriteLine("Kayıtlı Takım Üyeleri");
                        foreach(int i in takim.Keys){
                            Console.WriteLine($"{i}: {takim[i]}");
                        }
                        Console.WriteLine("Lütfen yukarıdan bir takım üyesi seçiniz ve id değerini giriniz: ");

                        int id = int.Parse(Console.ReadLine());
                        if(!takim.ContainsKey(id)){
                            Console.WriteLine("Üye İD bulunamadı tekrar seçiniz");
                            goto tekraruyesec;
                        }

                        board.CardEkle(title,content,size,id,kolon);
                        
                    }
                    break;
                case "3":
                    {
                        //kart sil
                        tekrarisim:
                        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                        Console.WriteLine("Lütfen kart başlığını yazınız");

                        string title = Console.ReadLine();
                        if(board.CardVarmi(title)){
                            board.CardSil(title);
                        }else{
                            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                            Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                            Console.WriteLine("* Yeniden denemek için : (2)");
                            string cevap = Console.ReadLine();
                            if(cevap=="1"){
                                goto tekrar;
                            }else{
                                goto tekrarisim;
                            }
                        }
                    }
                    break;
                case "4":
                    {
                        //kart taşı
                        tekrarisim:
                        Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
                        Console.WriteLine("Lütfen kart başlığını yazınız");

                        string title = Console.ReadLine();
                        if(board.CardVarmi(title)){
                            string from = board.CardLineBul(title);
                            Console.WriteLine("Card'ı hangi kolona taşımak istiyorsunuz(TODO,IN PROGRESS,DONE)?");
                            string kolon = Console.ReadLine();
                            board.CardTasi(title,from,kolon);
                        }else{
                            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                            Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                            Console.WriteLine("* Yeniden denemek için : (2)");
                            string cevap = Console.ReadLine();
                            if(cevap=="1"){
                                goto tekrar;
                            }else{
                                goto tekrarisim;
                            }
                        }
                    }
                    break;
                case "5":
                    {
                        //kart güncelle
                        tekrarisim:
                        Console.WriteLine("Öncelikle güncellemek istediğiniz kartı seçmeniz gerekiyor.");
                        Console.WriteLine("Lütfen kart başlığını yazınız");

                        string title = Console.ReadLine();
                        if(board.CardVarmi(title)){
                            Console.WriteLine("Güncel İçerik Giriniz                                 :");
                            string content = Console.ReadLine();
                            Console.WriteLine("Yeni Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
                            int size = int.Parse(Console.ReadLine());
                            Console.WriteLine("Yeni Kişi Seçiniz                                   :");
                            tekraruyesec:
                            Console.WriteLine("Kayıtlı Takım Üyeleri");
                            foreach(int i in takim.Keys){
                                Console.WriteLine($"{i}: {takim[i]}");
                            }
                            Console.WriteLine("Lütfen yukarıdan bir takım üyesi seçiniz ve id değerini giriniz: ");

                            int id = int.Parse(Console.ReadLine());
                            if(!takim.ContainsKey(id)){
                                Console.WriteLine("Üye İD bulunamadı tekrar seçiniz");
                                goto tekraruyesec;
                            }

                            board.CardGuncelle(title,new Card(title,content,size,id));
                            
                        }else{
                            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                            Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                            Console.WriteLine("* Yeniden denemek için : (2)");
                            string cevap = Console.ReadLine();
                            if(cevap=="1"){
                                goto tekrar;
                            }else{
                                goto tekrarisim;
                            }
                        }
                    }
                    break;
                default:
                {
                    goto tekrar;
                }
            }
        }

        public static void SecenekleriGetir(){
            string[] s = {"Lütfen yapmak istediğiniz işlemi seçiniz :) ","*******************************************","(1) Board Listelemek","(2) Board'a Kart Eklemek","(3) Board'dan Kart Silmek","(4) Kart Taşımak","(5) Kart Güncellemek"};
            foreach(string st in s)
            {
                Console.WriteLine(st);
            }
        }
    }
}