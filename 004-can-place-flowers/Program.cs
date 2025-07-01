// https://leetcode.com/problems/can-place-flowers/?envType=study-plan-v2&envId=leetcode-75

/*
 605. Can Place Flowers

You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

Example 1:

Input: flowerbed = [1,0,0,0,1], n = 1
Output: true

Example 2:

Input: flowerbed = [1,0,0,0,1], n = 2
Output: false
 */



static bool CanPlaceFlowers(int[] flowerbed, int n)
{
    var count = 0;
    for (int i = 0; i < flowerbed.Length; i++)
    {
        if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
        {
            flowerbed[i++] = 1;
            count++;
        }

        if (count >= n) return true;
    }

    return count >= n;
}

int[] flowerbed = []; int n = 0;

flowerbed = [1, 0, 0, 0, 1]; n = 1;
// Output: true
Console.WriteLine(CanPlaceFlowers(flowerbed, n));

flowerbed = [1, 0, 0, 0, 1]; n = 2;
// Output: false
Console.WriteLine(CanPlaceFlowers(flowerbed, n));

flowerbed = [0, 0, 1, 0, 1]; n = 1;
// Output: false
Console.WriteLine(CanPlaceFlowers(flowerbed, n));

flowerbed = [1, 0, 0, 0, 1, 0, 0]; n = 2;
// Output: false
Console.WriteLine(CanPlaceFlowers(flowerbed, n));

flowerbed = [1, 0, 0, 0, 0, 0, 0, 0, 1]; n = 3;
// Output: false
Console.WriteLine(CanPlaceFlowers(flowerbed, n));
