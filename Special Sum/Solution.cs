namespace Special_Sum
{
    internal class Solution
    {
        public int SpecialSum(int[] arr, int n)
        {
            int[] prefixSum = new int[n];
            prefixSum[0] = arr[0];
            for (int i = 1; i < n; i++)
            {
                prefixSum[i] = arr[i] + prefixSum[i - 1];
            }

            int specialSum = int.MaxValue;
            for (int i = 0; i < n; ++i)
            {
                int firstSum = prefixSum[i];
                int lastSum = n - i - 2 >= 0 ? prefixSum[n - 1] - prefixSum[n - i - 2] : prefixSum[n - 1];
                specialSum = Math.Min(specialSum, firstSum + lastSum);
            }

            return specialSum;
        }
    }
}
