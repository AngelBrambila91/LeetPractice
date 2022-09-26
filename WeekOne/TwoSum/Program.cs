using System;
using static System.Console;

namespace Test
{
    class Program
    {
    static void Main()
    {
        WriteLine(TwoSum2(new int [] {2, 5, 5, 11}, 10));
    }
    #region Take 1 of Two Sum
    static int[] TwoSum(int[] nums, int target) 
        {
        bool flag = false;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1 ; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    flag = true;
                    return new int [] {i , j};
                }
                else
                {
                    continue; 
                }
            }
            if(flag)
            {
                break;
            }
        }
        return new int [] {-1,-1};
        }
    #endregion

    #region Take Two on Two Sum
        static int[] TwoSum2(int[] nums, int target)
        {
            int i = 0;
            int j = 1;
            while (i < nums.Length && j < nums.Length)
            {
                if(nums[i] + nums[j] == target)
                {
                    return new int [] {i , j};
                }
                else if (j != nums.Length -1)
                {
                    j ++;
                    continue;
                }
                else
                {
                    i ++;
                    j = i + 1;
                }
            }
            return new int [] {-1,-1};
        }
    #endregion
    
    static int [] MergeSort (int [] toBeSorted)
    {
        int [] sorted  = new int [] {};
        int gap = toBeSorted.Length / 2;
        return sorted;
    }
    }
}