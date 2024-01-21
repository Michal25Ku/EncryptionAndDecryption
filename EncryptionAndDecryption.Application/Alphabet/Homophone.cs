using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Alphabet
{
    public class Homophone : IHomophone
    {
        private char[] Homophones { get; set; } = new char[]
        {
            'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o',
            'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ź', 'ż', 'A', 'Ą', 'B', 'C', 'Ć',
            'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'Q', 'R', 'S',
            'Ś', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ź', 'Ż', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')',
            '-', '=', '+', '<', '>', '?', '[', ']', '{', '}', '|', '€', '`', '_', '1', '2', '3', '4', '5', '6',
            '7', '8', '9', '0', '‰', '§', '©', '®',
        };

        public char[] AllHomophone() => Homophones;

        public Dictionary<char, char[]> GetLetterWithTheirHomophone(char[] alphabetWithNumberOfHomophone)
        {
            Dictionary<char, char[]> letterHomophones = new Dictionary<char, char[]>();
            char[] shuffledArray = GetShuffledArray(Homophones);

            int k = 0;
            for (int i = 0; i < alphabetWithNumberOfHomophone.Length - 1; i += 2)
            {
                char[] oneLetterArray = new char[int.Parse(alphabetWithNumberOfHomophone[i + 1].ToString())];
                for(int j = 0; j < oneLetterArray.Length; j++)
                {
                    oneLetterArray[j] = shuffledArray[k];
                    k++;
                }
                letterHomophones.Add(alphabetWithNumberOfHomophone[i], oneLetterArray);
            }

            return letterHomophones;
        }

        private char[] GetShuffledArray(char[] array)
        {
            char[] shuffledAlphabet = (char[])array.Clone();
            Random random = new Random();

            for (int i = shuffledAlphabet.Length - 1; i > 0; i--)
            {
                int randomPosition = random.Next(0, i + 1);

                char temp = shuffledAlphabet[i];
                shuffledAlphabet[i] = shuffledAlphabet[randomPosition];
                shuffledAlphabet[randomPosition] = temp;
            }

            return shuffledAlphabet;
        }
    }
}
