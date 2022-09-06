

/*

Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

*/


Console.Write("Pozitif bir sayı giriniz: ");
int n = int.Parse(Console.ReadLine());
string[] words = new string[n];
for(int i=0;i<n;i++){
    Console.Write("Bir Kelime Giriniz: ");
    words.Append(Console.ReadLine());
}
 
words.Reverse();
foreach(string w in words){
    Console.Write(w +" ");
}