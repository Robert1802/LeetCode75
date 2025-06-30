// https://leetcode.com/problems/merge-strings-alternately/?envType=study-plan-v2&envId=leetcode-75

/*
1768. Merge Strings Alternately (Easy)
You are given two strings word1 and word2.
Merge the strings by adding letters in alternating order, starting with word1.
If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"

 */


static string MergeAlternately(string word1, string word2)
{
    string mergedString = "";
    int maxLenth = (word1.Length >= word2.Length ? word1.Length : word2.Length);

    for (int i = 0; i < maxLenth; i++)
    {
        if (word1.Length > i) mergedString += word1[i];
        if (word2.Length > i) mergedString += word2[i];
    }

    return mergedString;
}

string word1 = "abc";
string word2 = "pqr";
Console.WriteLine(MergeAlternately(word1, word2)); // "apbqcr"

word1 = "ab";
word2 = "pqrs";
Console.WriteLine(MergeAlternately(word1, word2)); // "apbqrs"

word1 = "abcd";
word2 = "pq";
Console.WriteLine(MergeAlternately(word1, word2)); // "apbqcd"