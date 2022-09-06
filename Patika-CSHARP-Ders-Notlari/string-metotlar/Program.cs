string değişken = "Dersimiz CSharp, Hoşgeldiniz!";
string değişken2 = "Dersimiz CSharp";

//Length -- uzunluk
Console.WriteLine(değişken.Length);

//ToUpper -> hepsi büyük, ToLower -> hepsi küçük

Console.WriteLine(değişken.ToUpper());
Console.WriteLine(değişken.ToUpper());

//Concat --> birleştirme yapar
Console.WriteLine(string.Concat(değişken,"merhaba"));

//compare compareTo
Console.WriteLine(değişken.CompareTo(değişken2)); 
Console.WriteLine(string.Compare(değişken,değişken2,true)); 
Console.WriteLine(string.Compare(değişken,değişken2,false));

//Contains
Console.WriteLine(değişken.Contains(değişken2));
Console.WriteLine(değişken.EndsWith("Hoşgeldiniz!")); 
Console.WriteLine(değişken.StartsWith("merhaba")); 

//İndexOf

Console.WriteLine(değişken.IndexOf("CSharp")); 
Console.WriteLine(değişken.IndexOf("Mahmur")); 

//İnsert
Console.WriteLine(değişken.Insert(0,"Merhaba")); 

//LastIndexOF
Console.WriteLine(değişken.LastIndexOf("i")); 

Console.WriteLine(değişken + değişken2.PadLeft(30));
Console.WriteLine(değişken + değişken2.PadLeft(30,'*'));

Console.WriteLine(değişken.PadRight(50) + değişken2);
Console.WriteLine(değişken.PadRight(50,'-') + değişken2);

//Remove
Console.WriteLine(değişken.Remove(10));
Console.WriteLine(değişken.Remove(5,3));
Console.WriteLine(değişken.Remove(0,1));

//Replace
Console.WriteLine(değişken.Replace("CSharp","c#"));  
Console.WriteLine(değişken.Replace(" ","*")); 

//Split
Console.WriteLine(değişken.Split(' ')[1]);

//Substring
Console.WriteLine(değişken.Substring(5)); 
Console.WriteLine(değişken.Substring(5,8)); 