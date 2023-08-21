using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace palindromicFinder
{
    public class PalindromicService
    {
        public string FindPalindromic(string text)
        {
            string currentPalindromic = string.Empty;

            for (int x = 0; x < text.Length; x++)
            {
                for (int y = x + 1; y <= text.Length; y++)
                {
                    var possiblealindromic = text.Substring(x, y - x);

                    if (CheckIsPalindromic(possiblealindromic) && possiblealindromic.Length > currentPalindromic.Length)
                        currentPalindromic = possiblealindromic;
                }
            }

            return currentPalindromic;
        }

        private bool CheckIsPalindromic(string text)
        {

            int x = 0, y = text.Length - 1;

            while (true)
            {
                if (x > y)
                    return true;

                var xLetter = text[x];
                var yLetter = text[y];

                if (char.ToUpperInvariant(xLetter) != char.ToUpperInvariant(yLetter))
                    return false;

                x++;
                y--;
            }
        }
    }
}