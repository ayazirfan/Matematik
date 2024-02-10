

using Matematik;

System.Console.WriteLine("Taban Sayıyı giriniz.");
double s1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Üst olacak sayıyı giriniz.");
double s2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("{0}^{1} = {2}",s1,s2,Formuller.UstAlma(s1,s2));

int [] asalCarpanlar = Formuller.AsalCarpanlar(32);
for (int i = 0; i < asalCarpanlar.Length; i++)
{
    System.Console.WriteLine(asalCarpanlar[i]);
}

