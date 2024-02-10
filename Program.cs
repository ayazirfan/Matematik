

using Matematik;

System.Console.WriteLine("Taban Sayıyı giriniz.");
double s1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Üst olacak sayıyı giriniz.");
double s2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("{0}^{1} = {2}",s1,s2,Formuller.UstAlma(s1,s2));

System.Console.WriteLine("{0} sayisinin asal carpanlarının toplamı = {1}",32,Formuller.AsalCarpanlarinToplami(32));

System.Console.WriteLine("{0} sayisinin asal carpanlarının carpımı = {1}",32,Formuller.AsalCarpanlarinCarpimi(32));

