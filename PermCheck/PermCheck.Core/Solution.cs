namespace PermCheck.Core
{
    using System.Collections.Generic;

    public class Solution
    {
        public int IsArrayPermutation(int[] array)
        {            
            var dict = new Dictionary<int, int>();

            foreach (var elem in array)
            {
                if (!dict.ContainsKey(elem))
                {
                    dict.Add(elem, elem);
                }
                else
                {
                    return 0;
                }
            }
            
            for (var i = 1; i <= array.Length; i++)
            {
                if (!dict.ContainsKey(i))
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}
