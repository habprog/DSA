using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Solutions
{
    public class TwoSumSolution
    {
        public int[] TwoSumForLoopApproach(int[] nums, int target)
        {
            for (int o = 0; o < nums.Length; o++)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if (o != i && (nums[o] + nums[i]) == target)
                    {
                        return new[] { o, i };
                    }
                }
            }
            return new int[0];
        }

        public int[] TwoSumHashTableApproach(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                map[nums[i]] = i;
            }
            return new int[0];
        }
    }
}
