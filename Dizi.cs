namespace Matematik;

public class Dizi
{
/// <summary>
/// Virgülle ayrılmış olarak girilen string diziyi sayısal diziye çevirir.
/// </summary>
/// <param name="ifade"></param>
/// <returns></returns>
    public int [] IfadeyiDiziyeCevir(string ifade)
    {
     string [] bolunmusIfade= ifade.Split(',');
     int n = bolunmusIfade.Length;
     //sayısal dizi
     int [] sayisalDizi = new int[n];

     // Ayrıştırma
     for (int i = 0; i < n; i++)
     {
        sayisalDizi[i] = Convert.ToInt32(bolunmusIfade[i]);
        System.Console.WriteLine("dizi [{0}] = {1}", i ,sayisalDizi[i]); 
     }
     return sayisalDizi;
    }

}
