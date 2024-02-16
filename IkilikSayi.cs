namespace Matematik;

public class IkilikSayi
{
    public static int IkilikTabandanOnlukTabana(string ikilikSayi)
    {
        // Uzunluğu belirle
        int n = ikilikSayi.Length;

        //her bir basamağın dizide tutulması
        int [] basamaklar = new int[n];

        // onluk karşılığı
        int sayi = 0;
        bool kontrol = true;
        for (int i = 0; i < n; i++)
        {
         if (!(ikilikSayi[i]=='0'|| ikilikSayi[i]=='1' ))
         {
            System.Console.WriteLine("\aHatalı Giriş!");
            kontrol = false;
            break;
         }   
         basamaklar[i] = (int)(ikilikSayi[i] - '0');
        }
        //2'lik sistemden 10'luk sisteme geçiş
        if (kontrol)
        {
            for (int i = 0; i < n; i++)
            {
                sayi+=(int)Math.Pow(2,n-1-i)*basamaklar[i];
            }
            System.Console.WriteLine("({0} ikilik sayı = {1})",ikilikSayi,sayi);
        }
        return sayi;

    }

}
