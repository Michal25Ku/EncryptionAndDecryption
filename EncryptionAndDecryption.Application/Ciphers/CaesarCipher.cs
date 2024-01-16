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
        private char[] _currentAlphabet { get; set; }

        public CaesarCipher()
        {
            Alphabets = new Alphabets();
            _currentAlphabet = Alphabets.FoundAlphabet("Pl");
        }

        public string? EncryptedText { get; set; }
        public string? DecryptedText { get; set; }

        public void Decrypt(string encryptedText, int shift = 0)
        {
            if (encryptedText == null)
                return;

            var letters = encryptedText.ToLower().Where(l => char.IsLetter(l) || char.IsNumber(l)).ToArray();
            var decryptedText = new char[encryptedText.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                decryptedText[i] = _currentAlphabet[(Array.IndexOf(_currentAlphabet, letters[i]) + _currentAlphabet.Length - shift) % _currentAlphabet.Length];
            }

            DecryptedText = new string(decryptedText);
        }

        public void Encrypt(string plainText, int shift = 0)
        {
            if (plainText == null)
                return;

            var letters = plainText.ToLower().Where(l => char.IsLetter(l) || char.IsNumber(l)).ToArray();
            var encryptedText = new char[plainText.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                encryptedText[i] = _currentAlphabet[(Array.IndexOf(_currentAlphabet, letters[i]) + shift) % _currentAlphabet.Length];
            }

            EncryptedText = new string(encryptedText);
        }

        public char[] SetAlphabet(string AlhpabetName)
        {
            _currentAlphabet = Alphabets.FoundAlphabet(AlhpabetName);
            return _currentAlphabet;
        }

        public char[] GetCurrentAlphabet()
        {
            return _currentAlphabet;
        }
    }
}
