namespace PermCheck.Core
{
    using System.Collections.Generic;

    public class Solution
    {
        public int IsArrayPermutation(int[] array)
        {
            var max = 0;
            var list = new List<int>();

            foreach (var elem in array)
            {
                list.Add(elem);
                if (elem > max)
                {
                    max = elem;
                }
            }

            var isPerm = 1;
            for (var i = 1; i <= max; i++)
            {
                if (!list.Contains(i))
                {
                    isPerm = 0;
                    break;                    
                }
            }

            return isPerm;
        }        
    }
}
