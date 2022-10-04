using System;
using static System.Console;
namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -1, 0, 3, 5, 9, 12 };
            WriteLine(Search(nums, 9));
        }

        #region Using iterative
        // 148 ms, almost there
        public static int Search(int[] nums, int target)
        {
            int lo = 0;
            int hi = nums.Length - 1;

            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;

                if (nums[mid] == target)
                    return mid;

                if (nums[mid] > target)
                    hi = mid - 1;
                else
                    lo = mid + 1;
            }

            return -1;
        }
        #endregion

        #region Using merge kind of search
        // 252 ms, not good enough
        // public static int Search(int [] nums, int target)
        // {
        //     return BinarySearch(nums, 0, nums.Length - 1, target);
        // }

        // public static int BinarySearch (int [] nums, int left, int right, int target)
        // {
        //     int mid = (right + left) / 2;
        //     if(target == nums[mid])
        //     {
        //         return mid;
        //     }
        //     if(left == right)
        //     {
        //         return -1;
        //     }   
        //     if(nums[mid] > target)
        //     {
        //         return BinarySearch(nums, left, mid - 1, target);
        //     }
        //     return BinarySearch(nums, mid + 1, right, target);
        // }
        #endregion

        #region Testing IndexOf
        // 235 ms, not good enough
        // public static int Search (int [] nums, int target)
        // {
        //     if(nums == null)
        //     {
        //         return -1;
        //     }
        //     return Array.IndexOf(nums, target);
        // }
        #endregion

        #region Testing Iterative solution
        // 310 ms, not good.
        //     public static int Search(int [] nums, int target)
        //     {
        //     int l = 0, r = nums.Length - 1;
        //     while (l <= r) {
        //     int m = l + (r - l) / 2;

        //     // Check if x is present at mid
        //     if (nums[m] == target)
        //         return m;

        //     // If x greater, ignore left half
        //     if (nums[m] < target)
        //         l = m + 1;

        //     // If x is smaller, ignore right half
        //     else
        //         r = m - 1;
        // }

        // // if we reach here, then element was
        // // not present
        // return -1;
        // }
        #endregion
    
        #region Using built-in Binary Search
        // 217 ms
            // public static int Search(int[] nums, int target)
            // {
            //     int i = Array.BinarySearch(nums, target);
            //     return (i < 0) ? -1 : i;
            // }
        #endregion
    }
}