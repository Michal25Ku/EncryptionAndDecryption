using EncryptionAndDecryption.Application.Alphabet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EncryptionAndDecryption.Application.Ciphers
{
    public class CaesarCipher : ICipher
    {
        public IAlphabet Alphabets { get; set; }
        private char[] CurrentAlphabet { get; set; }

        public CaesarCipher()
        {
            Alphabets = new Alphabets();
            CurrentAlphabet = Alphabets.FoundAlphabet("Pl");
        }

        public string? EncryptedText { get; set; }
        public string? DecryptedText { get; set; }

        public void Decrypt(string encryptedText, int shift = 0)
        {
            if (encryptedText == null)
                return;

            var letters = encryptedText.ToLower().Where(l => char.IsLetter(l) || char.IsNumber(l)).ToArray();
            string decryptedText = "";

            for (int i = 0; i < letters.Length; i++)
            {
                if (Char.IsNumber(letters[i]) || letters[i] == ' ')
                    decryptedText += " ";
                else
                    decryptedText += CurrentAlphabet[(Array.IndexOf(CurrentAlphabet, letters[i]) + CurrentAlphabet.Length - shift) % CurrentAlphabet.Length];
            }

            DecryptedText = new string(decryptedText);
        }

        public void Encrypt(string plainText, int shift = 0)
        {
            if (plainText == null)
                return;

            var letters = plainText.ToLower().Where(l => char.IsLetter(l) || char.IsNumber(l)).ToArray();
            string encryptedText = "";

            for (int i = 0; i < letters.Length; i++)
            {
                if (Char.IsNumber(letters[i]))
                    continue;
                else
                    encryptedText += CurrentAlphabet[(Array.IndexOf(CurrentAlphabet, letters[i]) + shift) % CurrentAlphabet.Length];
            }

            EncryptedText = new string(encryptedText);
        }

        public char[] GetCurrentAlphabet() => CurrentAlphabet;

        public void Action(object obj)
        {
            return;
        }
    }
}
