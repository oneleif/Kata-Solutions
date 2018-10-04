//link: https://www.codewars.com/kata/566fc12495810954b1000030
using System.Linq;
public class CountDig 
{
    
    public static int NbDig(int n, int d) 
    {
            int numDigits = 0;
            for(int i = 0; i <= n; i++)
            {
                int square = i * i;
                numDigits += square.ToString().Count(x => x == d.ToString()[0]);
            }

            return numDigits;
    }
}