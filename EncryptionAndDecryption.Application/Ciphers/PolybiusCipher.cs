using EncryptionAndDecryption.Application.Alphabet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Ciphers
{
    public class PolybiusCipher : ICipher
    {
        public IAlphabet Alphabets { get; set; }
        private char[] _currentAlphabet { get; set; }

        public string? EncryptedText { get; set; }
        public string? DecryptedText { get; set; }

        public void Decrypt(string encryptedText, int shift = 0)
        {
            throw new NotImplementedException();
        }

        public void Encrypt(string plainText, int shift = 0)
        {
            throw new NotImplementedException();
        }

        public char[] SetAlphabet(string AlhpabetName)
        {
            throw new NotImplementedException();
        }

        public char[] GetCurrentAlphabet()
        {
            return _currentAlphabet;
        }
    }
}
