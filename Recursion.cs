namespace Data_Structures
{
    public class Recursion
    {
        public long Factorial(int n) {
            if(n == 0) return 1;
            return n * Factorial( n - 1);
        }

        public long Factorial_NonRecursion(int n) {
            long retVal = 1;
            for (int i = n; i >= 1; i--){
                retVal = retVal * i;
            }
            return retVal; 
        }
    }
}