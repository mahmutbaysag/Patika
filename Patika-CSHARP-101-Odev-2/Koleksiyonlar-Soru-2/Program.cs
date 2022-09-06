

int[] dizi = new int[20];

for(int i=0;i<20;i++){
    Console.Write((i+1).ToString() +".Sayıyı gir: ");
    dizi[i] = int.Parse(Console.ReadLine());
}

for(int i=0;i<dizi.Length-1;i++){
    for(int j=i;j<dizi.Length-2;j++){
        if(dizi[j]<dizi[i]){
            int tempnum = dizi[j];
            dizi[j] = dizi[i];
            dizi[i] = tempnum;
        }
    }
}

int[] enk,enb = new int[3];//en küçük ve en büyük 3 sayının depolandığı dizi
double enkort,enbort;
for(int i=0;i<3;i++){
    enk[i]=dizi[i];
    enb[i]=dizi[19-i];
    enkort += enk[i]/3;
    enbort += enb[i]/3;
}

Console.WriteLine("EN küçük 3 sayının Ortalaması: "+enk.ToString());
Console.WriteLine("EN büyük 3 sayının Ortalaması: "+enb.ToString());

Console.WriteLine("Ortalamaların Toplamları: "+ (enk+enb).ToString());