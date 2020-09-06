using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) {
            //Insert the correct implementation here
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            String newWord1 = new string(char1);
            String newWord2 = new string(char2);
            if (newWord1 == newWord2)
            {
                Console.WriteLine("words {0} and {1} are Anagrams", word1, word2);
                return true;
            }
            else
            {
                Console.WriteLine("words {0} and {1} are Not Anagrams", word1, word2);
                return false;
            }

        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            //Insert the correct implementation here
            for (int i = 0; i < candidates.Count; i++)
            {
                String newword = candidates[i];
                bool condition = WordPairIsAnagram(word, newword);
                if (!condition)
                {
                    candidates.Remove(newword);
                }
            }
            return candidates;
        }
    }
}
