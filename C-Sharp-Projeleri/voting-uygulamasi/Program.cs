

Voiting voiting = new Voiting();
tekrar:
Console.Write("Kullanıcı Adınızı Giriniz: ");
string name = Console.ReadLine();
if(voiting.kullanicilar.KullaniciVarmi(name)){
    voiting.KategoriListele();
    Console.WriteLine("Oy vermek istediğiniz kategorinin numarasını giriniz: ");
    int oy = int.Parse(Console.ReadLine());
    voiting.OyVer(oy);
}else{
    voiting.kullanicilar.Add();
    goto tekrar;
}