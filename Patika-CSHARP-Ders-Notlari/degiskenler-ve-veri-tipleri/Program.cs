//dotnet 6 versiyonunda namespace ve class gibi tanımlar ile vakit kaybedilmeden direk kodlamaya başlanabilir

byte a = 2;         
sbyte a1 = 1;    

short b = 8;        
ushort b1 = 16;   

Int16 c=3;        
int c1 = 4;          
Int32 c2 = 9;      
Int64 c3 = 4;      
uint c4 = 1;        
long d = 8;         
ulong d1 = 1;     

float f = 8;        
double f1 = 56;       
decimal f2 = 7.8m;  

char g = '5';        
string g1 = "Mahmut"; 

bool h = true;       
bool h1 = false;      

DateTime tarih = DateTime.Now; 

object obje1 = "x"; 
object obje2 = 'y'; 
object obje3 = 4; 
object obje4 = 4.3;

string s1 = string.Empty; 
s1 = "Mahmut Baysağ";
string ad = "Mahmut";
string soyad = "Baysağ";
string tamIsim = ad + " " + soyad;

int i1 = 1;
int i2 = 2;
int i3 = i1 * i2;

bool bd1 = 10<2;
string sd1 = "20";
int id1 = 20;
string sd2 = s1 + id1.ToString();
int int21 = id1 + Convert.ToInt32(sd1); 
int int22 = id1 + int.Parse(sd1);

string dt = DateTime.Now.ToString("dd.MM.yyyy"); 
Console.WriteLine(dt);
string dt1 = DateTime.Now.ToString("dd//MM/yyyy"); 
Console.WriteLine(dt1);
string saat = DateTime.Now.ToString("HH.mm");
Console.WriteLine(saat);