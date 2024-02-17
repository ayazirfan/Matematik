

using Matematik;

System.Console.WriteLine("Taban Sayıyı giriniz.");
double s1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Üst olacak sayıyı giriniz.");
double s2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("{0}^{1} = {2}",s1,s2,Formuller.UstAlma(s1,s2));

// System.Console.WriteLine("{0} sayisinin asal carpanlarının toplamı = {1}",32,Formuller.AsalCarpanlarinToplami(32));

// System.Console.WriteLine("{0} sayisinin asal carpanlarının carpımı = {1}",32,Formuller.AsalCarpanlarinCarpimi(32));

 //System.Console.WriteLine("OKEK({0},{1}) = {2}",s1,s2, OKEKOBEB.OKEK((int)s1, (int)s2));
 System.Console.WriteLine("OBEB({0},{1}) = {2}",s1,s2, OKEKOBEB.OBEB((int)s1, (int)s2));
 System.Console.WriteLine("{0}! = {1}", s1,Faktoriyel.FaktoriyelAl((int)s1));
double t = 0;
for (int i = 2; i < 9; i++)
{
    t+=Faktoriyel.FaktoriyelAl(i);
    System.Console.WriteLine("{0}! = {1}", i,Faktoriyel.FaktoriyelAl(i));   
}

int [] dizi = new Dizi().IfadeyiDiziyeCevir("2,3,4,5,6,45,688,67");

int a= IkilikSayi.IkilikTabandanOnlukTabana("102");
System.Console.WriteLine(a);
int b = new SesliHarf().SesliHarfSayisi("KöpEk");
System.Console.WriteLine(b);


