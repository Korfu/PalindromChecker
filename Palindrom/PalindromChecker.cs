using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    public static class PalindromChecker
    {
        public static bool IsPalindrom(string word)
        {
            word = word.ToLower();
            var result = true;
            for (var i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
