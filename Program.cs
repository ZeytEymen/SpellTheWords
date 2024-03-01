namespace Spelling
{
    public class Program
    {
        static bool isVowelLetter(char ch) => "aeıiuüoöAEIİOÖUÜ".Contains(ch) ? true : false;
        static bool isFirstSpell(string str) => !str.Any(c => "aeıiuüoöAEIİOÖUÜ".Contains(c));
        static void Main(string[] args)
        {
            string word = "Schwarzenegger";//The word you wanna spell it.
            string spell = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                spell += word[i];
                if (isVowelLetter(word[i])  && isFirstSpell(word.Substring(0, i)))
                    continue;
                if (isVowelLetter(word[i]) && !isVowelLetter(word[((i - 1) >= 0) ? (i - 1) : (i)]))
                    spell += word[--i] + "-";
                else if (isVowelLetter(word[i]) && isVowelLetter(word[((i - 1) >= 0) ? (i - 1) : (i)]))
                    spell += "-";
            }
            for (int i = spell.Length - 1; i >= 0; Console.Write(spell[i]), i--);
        }
    }
}
