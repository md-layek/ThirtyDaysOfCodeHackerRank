namespace Bitwise_AND;

public class Result
{
    /*
     * Complete the 'bitwiseAnd' function below.
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER N
     *  2. INTEGER K
     */

    public static int bitwiseAnd(int N, int K)
    {
        
        int i,j,maxResult;
        maxResult=K-1;
        while(maxResult>0) {            
            for( i=N;i>0;i--) {
                for( j=i-1;j>0;j--) {
                    if((i&j) == maxResult ) return maxResult;
                }
            }
            maxResult--;
        }
        return 0;
       
    }

}
