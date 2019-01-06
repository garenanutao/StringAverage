using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage
{
    public class Kata
    {
        public Dictionary<string, int> NumsMapping;
        public Kata()
        {
            NumsMapping = new Dictionary<string, int>();
            NumsMapping.Add("zero", 0);
            NumsMapping.Add("one", 1);
            NumsMapping.Add("two", 2);
            NumsMapping.Add("three", 3);
            NumsMapping.Add("four", 4);
            NumsMapping.Add("five", 5);
            NumsMapping.Add("six", 6);
            NumsMapping.Add("seven", 7);
            NumsMapping.Add("eight", 8);
            NumsMapping.Add("nine", 9);
        }
        public string AverageString(string str)
        {
            if (str == null) return "n/a";
            string[] nums = str.Split(new char[] { ' ' });
            int sum = 0;
            int tmp = -1;
            foreach (var num in nums)
            {
                if (!NumsMapping.TryGetValue(num, out tmp)) return "n/a";
                sum += tmp;
            }
            sum /= nums.Length;
            return NumsMapping.ElementAt(sum).Key;
        }
    }

}
