namespace Matematik;

public class SesliHarf
{
 /// <summary>
 /// Girilen ifadedki harf sayısını döner.
 /// </summary>
 /// <param name="ifade">String ifadesi</param>
 /// <returns>Sesli harf sayısı</returns>
    public int SesliHarfSayisi ( string ifade)
    {
        int sesliHarf = 0;

        for (int i = 0; i < ifade.Length; i++)
        {
            if (ifade[i]== 'a'|| ifade[i]=='A' ||
                ifade[i]== 'e'|| ifade[i]=='E' ||
                ifade[i]== 'ı'|| ifade[i]=='I' ||
                ifade[i]== 'i'|| ifade[i]=='İ' ||
                ifade[i]== 'ö'|| ifade[i]=='Ö' ||
                ifade[i]== 'u'|| ifade[i]=='U' ||
                ifade[i]== 'ü'|| ifade[i]=='Ü' ||
                ifade[i]== 'o'|| ifade[i]=='O')
            {
                sesliHarf++;
            }
        }
        System.Console.WriteLine("{0} ifadesinde {1} sesli harf var." ,ifade,sesliHarf);
        return sesliHarf;
    }

}
