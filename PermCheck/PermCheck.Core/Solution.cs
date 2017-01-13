namespace PermCheck.Core
{
    using System.Collections.Generic;

    public class Solution
    {
        public int IsArrayPermutation(int[] array)
        {
            var max = 0;
            var dict = new Dictionary<int, int>();
            
            foreach (var elem in array)
            {                
                if (!dict.ContainsKey(elem))
                {
                    dict.Add(elem, elem);
                }
                                
                if (elem > max)
                {
                    max = elem;
                }
            }

            if (max != array.Length)
            {
                return 0;
            }

            var isPerm = 1;
            for (var i = 1; i <= max; i++)
            {                
                if (!dict.ContainsKey(i))
                {
                    isPerm = 0;
                    break;                    
                }
            }

            return isPerm;
        }        
    }
}
