namespace Matematik;

public class OKEKOBEB
{
     public static int OKEK ( int s1 , int s2)
    {
        int s = 1;
        while (s1!=1 && s2!=1)
        {
            int bol =2;
            for (int i = 1; i <= (s1>s2 ? s1 : s2); i++)
            {
                if (s1 % bol == 0 || s2 % bol == 0)
                {
                s*=bol;
                if (s1%bol ==0)
                s1 /= bol;
                if (s2 % bol == 0)
                s2 /= bol;
                }                  
            
            else 
            bol++;
            }
        }
        
        return s;

    }
    public static int OBEB ( int s1 , int s2)
    {
        int s = 1;
        int bolen =2;
        while (s1!=1 && s2!=1)
        {
            
            for (int i = 2; i < (s1>s2 ? s1 : s2); i++)
            {
                if (s1%bolen==0 || s2%bolen==0 )
                {
                    if (s1%bolen==0 && s2%bolen==0)
                    s*=bolen;
                    if (s1%bolen==0)  
                    s1/=bolen;
                    if (s2%bolen==0)                
                    s2/=bolen;
               
                }
                else
                bolen++;
            }
        }
        return s;    
    }

}
