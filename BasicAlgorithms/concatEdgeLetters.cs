using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms
{
    public class ConcatEdgeLetters
    {
        public string[] Move(string[] a)
        {
            List<string> result = new List<string>();
            string word;
            for (int index = 0; index < a.Length - 1; index++)
            {
                word = a[index].Substring(0, 1) + a[index + 1].Substring(a[index + 1].Length - 1, 1);
                result.Add(word);
            }

            word = a[a.Length - 1].Substring(0, 1) + a[0].Substring(a[0].Length - 1, 1);
            result.Add(word);
            return result.ToArray();
        }
    }
}
