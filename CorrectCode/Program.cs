class Solution
{
    public int solution(int[] A)
    {
        int n = A.Length;
        int i = n - 1;
        int result = -1;
        int k = 0, maximal = 0;
        while (i >= 0) // To include index 0
        {
            if (A[i] == 1)
            {
                k = k + 1;
                if (k >= maximal)
                {
                    maximal = k;
                    result = i;
                }
            }
            else
                k = 0;
            i = i - 1;
        }
        if (A[i] == 1 && k + 1 > maximal)
            result = i; // Correct starting index of the sequence
        return result;
    }

    static void Main()
    {
        Solution solution = new Solution();

    }
}


