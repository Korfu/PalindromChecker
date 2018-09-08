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
            var newWord = word.ToLower().Replace(" ", "");
            var result = true;
            for (var i = 0; i < newWord.Length / 2; i++)
            {
                if (newWord[i] != newWord[newWord.Length - 1 - i])
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
