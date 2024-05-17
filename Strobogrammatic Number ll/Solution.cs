namespace Strobogrammatic_Number_ll
{
    internal class Solution
    {
        private void DFS(List<char> chars, List<string> ans, char[] candidate, int left, int right)
        {
            if (left > right)
            {
                ans.Add(new string(candidate));
                return;
            }

            foreach (char c in chars)
            {
                if (c == '0' && left == 0 && right != 0)
                {
                    continue;
                }

                if (left == right && (c == '6' || c == '9'))
                {
                    continue;
                }

                candidate[left] = candidate[right] = c;
                if (candidate[left] == '6')
                {
                    candidate[right] = '9';
                }

                if (candidate[left] == '9')
                {
                    candidate[right] = '6';
                }
                DFS(chars, ans, candidate, left + 1, right - 1);
            }
        }

        public List<string> FindStrobogrammatic(int n)
        {
            List<string> ans = [];
            char[] candidate = new char[n];
            List<char> validChars = ['0', '1', '6', '8', '9'];
            DFS(validChars, ans, candidate, 0, n - 1);
            return ans;
        }
    }
}
