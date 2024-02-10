namespace Matematik;
public class Formuller
{
/// <summary>
/// Parametre olarak aldığı taban ve kuvvet bagli olarak üst alma işlemini gerçekleştirir.
/// </summary>
/// <param name="taban">Taban</param>
/// <param name="kuvvet">Kuvvet</param>
/// <returns>S</returns>
public static double UstAlma (double taban, double kuvvet)
{
    double s = 1;
    for (int i = 1; i <= kuvvet; i++)
    {
        s*=taban;
    }return s;
}

/// <summary>
/// Bir sayının asal carpanlarını verir 
/// </summary>
/// <param name="n">Sayıyı temsil eder</param>
/// <returns>Asal carpanlar dizisidir</returns>
public static int [] AsalCarpanlar(int n)
{
    string carpanListesi = "";
    int i = 2;
    while (n>1)
    {
        if (n%i==0)
        {
            n=n/i;
            carpanListesi+=i.ToString() + ",";
        }
        else
        i++;
    }
    carpanListesi = carpanListesi.Substring(0, carpanListesi.Length-1);
    string [] carpanlar = carpanListesi.Split(",");
    string s = carpanlar[0];
    string y= s;

    for (int j = 0; j < carpanlar.Length; j++)
    {
        if (s!=carpanlar[j])
        {
            y= y+","+carpanlar[j];
            s=carpanlar[j];
        }
    }
    carpanlar = y.Split(',');
    int [] asalCarpanlar = new int[carpanlar.Length];
    for (int k = 0; k < asalCarpanlar.Length; k++)
    asalCarpanlar[k] = Convert.ToInt32(carpanlar[k]);
    return asalCarpanlar;
    
}
}
