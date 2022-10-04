using System;
using static System.Console;
namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(IsAnagram("aacc", "ccac"));
        }
    #region Using Brute Force 
        /// <summary>
        /// Attempt N1
        /// Time : 1581 ms Unnacceptable
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
    // public static bool IsAnagram(string s, string t) {
    //     if(s.Length != t.Length)
    //     {
    //         return false;
    //     }
    //     foreach (var item in t.ToArray())
    //     {
    //         if (!s.Contains(item))
    //         {
    //             return false;
    //         }
    //         else
    //         {
    //             s = s.Remove(s.IndexOf(item), 1);
    //         }
    //     }
    //     return true;
    // }
        #endregion

    #region Using Quick Sort
        // 526 ms, not good
        // public static bool IsAnagram(string s, string t) {
        // char [] arr = s.ToArray();
        // QuickSort(arr, 0, arr.Length -1);
        // char [] secondArr = t.ToArray();
        // QuickSort(secondArr, 0, secondArr.Length - 1);
        // s = new string(arr);
        // t = new string(secondArr);
        // return s == t;
        // }

        // public static void QuickSort (char[] arr, int low, int high)
        // {
        //     if(low < high)
        //     {
        //         int part = partition(arr, low, high);
        //         QuickSort(arr, low, part - 1);
        //         QuickSort(arr, part + 1, high);
        //     }
        // }

        // public static int partition(char [] arr, int low, int high)
        // {
        //     char pivot = arr[high];
        //     int i = (low - 1);
        //     for (int j = low; j <= high; j++)
        //     {
        //         if(arr[j] < pivot)
        //         {
        //             i++;
        //             swap(arr, i, j);
        //         }
        //     }

        //     swap(arr, i + 1, high);
        //     return (i + 1);

        // }

        // public static void swap (char [] arr, int i, int j)
        // {
        //     char temp = arr[i];
        //     arr[i] = arr[j];
        //     arr[j] = temp;
        // }
    #endregion
 
    #region Using Array Sort
    // 99ms , acceptable
    public static bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        var first = s.ToArray();
        var second = t.ToArray();
        Array.Sort(first);
        Array.Sort(second);
        s = new string(first);
        t = new string(second);
        return s == t;
    }
    #endregion
    }

}