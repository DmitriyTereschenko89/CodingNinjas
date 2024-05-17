namespace Count_the_loop
{
    internal class Solution
    {
        private int ConvertBinaryRepresantation(string num)
        {
            int ans = 0;
            int power = num.Length;
            for (int i = 0; i < num.Length; ++i)
            {
                int bit = num[i] - '0';
                ans += (int)Math.Pow(2, (power--)) * bit;
            }

            return ans;
        }

        public int CountLoop(string p, string q)
        {
            List<char> pChars = [.. p.ToCharArray()];
            List<char> qChars = [.. q.ToCharArray()];
            pChars.Reverse();
            qChars.Reverse();

            if (p.Length < q.Length)
            {
                int diff = q.Length - p.Length;
                for (int i = 0; i < diff; ++i)
                {
                    p += "0";
                }
            }
            else
            {
                int diff = p.Length - q.Length;
                for (int i = 0; i < diff; ++i)
                {
                    q += "0";
                }
            }

            int P = ConvertBinaryRepresantation(p);
            int Q = ConvertBinaryRepresantation(q);
            int ans = 0;
            while (Q > 0)
            {
                int A = P & Q;
                int B = P ^ Q;
                Q = A * 2;
                P = B;
                ++ans;
            }

            return ans;
        }
    }
}
