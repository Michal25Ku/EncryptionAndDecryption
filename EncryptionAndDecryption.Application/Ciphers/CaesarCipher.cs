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
        public char[] CurrentAlphabet { get; set; }

        public CaesarCipher()
        {
            Alphabets = new Alphabets();
            CurrentAlphabet = Alphabets.FoundAlphabet("Pl");
        }

        public string? EncryptedText { get; set; }
        public string? DecryptedText { get; set; }

        public void Decrypt(string encryptedText, int shift = 0)
        {
            var letters = encryptedText.ToLower().Where(l => char.IsLetter(l) || char.IsNumber(l)).ToArray();
            var decryptedText = new char[encryptedText.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                decryptedText[i] = CurrentAlphabet[(Array.IndexOf(CurrentAlphabet, letters[i]) + CurrentAlphabet.Length - shift) % CurrentAlphabet.Length];
            }

            DecryptedText = new string(decryptedText);
        }

        public void Encrypt(string plainText, int shift = 0)
        {
            var letters = plainText.ToLower().Where(l => char.IsLetter(l) || char.IsNumber(l)).ToArray();
            var encryptedText = new char[plainText.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                encryptedText[i] = CurrentAlphabet[(Array.IndexOf(CurrentAlphabet, letters[i]) + shift) % CurrentAlphabet.Length];
            }

            EncryptedText = new string(encryptedText);
        }

        public void SetAlphabet(string AlhpabetName)
        {
            CurrentAlphabet = Alphabets.FoundAlphabet(AlhpabetName);
        }
    }
}
