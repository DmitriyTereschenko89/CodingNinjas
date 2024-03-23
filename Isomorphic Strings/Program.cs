using Isomorphic_Strings;

string str1 = Console.ReadLine();
string str2 = Console.ReadLine();
Solution solution = new();
Console.WriteLine(solution.AreIsomorphic(str1, str2) ? 1 : 0);