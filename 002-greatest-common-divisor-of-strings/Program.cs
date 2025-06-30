// leetcode.com/problems/greatest-common-divisor-of-strings?envType=study-plan-v2&envId=leetcode-75

/*
1071. Greatest Common Divisor of Strings (Easy)

For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).

Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

Example 1:

Input: str1 = "ABCABC", str2 = "ABC"
Output: "ABC"
Example 2:

Input: str1 = "ABABAB", str2 = "ABAB"
Output: "AB"
Example 3:

Input: str1 = "LEET", str2 = "CODE"
Output: ""

 */

using System.Text;

static string GcdOfStrings(string str1, string str2)
{
    if (str1 == str2) return str1;
    if (str1.Length > str2.Length) return GcdOfStrings(str2, str1);

    int i = 1;
    while (i <= str1.Length)
    {
        var length = str1.Length / i;
        if ((str1.Length % length == 0) && (str2.Length % length == 0))
        {
            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();

            var result = str1.Substring(0, length);

            var x1 = str1.Length / length;
            for (int j = 0; j < x1; j++)
                sb1.Append(result);
            var x2 = str2.Length / length;
            for (int j = 0; j < x2; j++)
                sb2.Append(result);

            if ((str1 == sb1.ToString()) && (str2 == sb2.ToString()))
                return result;
        }
        i++;
    }

    return string.Empty;
}

string str1 = "";
string str2 = "";

str1 = "ABCABC"; str2 = "ABC";
Console.WriteLine(GcdOfStrings(str1, str2)); // Output: "ABC"

str1 = "ABABAB"; str2 = "ABAB";
Console.WriteLine(GcdOfStrings(str1, str2)); // Output: "AB";

str1 = "LEET"; str2 = "CODE";
Console.WriteLine(GcdOfStrings(str1, str2)); // Output: "";