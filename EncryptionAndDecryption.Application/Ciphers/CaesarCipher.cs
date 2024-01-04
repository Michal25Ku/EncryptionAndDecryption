using EncryptionAndDecryption.Application.Alphabet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Ciphers
{
    public class CaesarCipher : ICipher
    {
        public int Shift { get; set; }
        public Alphabets Alphabets { get; set; }
        public char[] CurrentAlphabet { get; set; }

        public CaesarCipher()
        {
            Shift = 0;
            Alphabets = new Alphabets();
            CurrentAlphabet = Alphabets.FoundAlphabet("Pl");
        }

        public string? EncryptedText { get; set; }
        public string? DecryptedText { get; set; }

        public void Decrypt(string encryptedText)
        {
            DecryptedText = "costam";
        }

        public void Encrypt(string plainText)
        {
            EncryptedText = "szaszyfrowane costam";
        }

        public void SetAdditionalFunctional(int? shift)
        {
            Shift = (int)shift;
        }

        public void SetAlphabet(string AlhpabetName)
        {
            Alphabets.FoundAlphabet(AlhpabetName);
        }
    }
}
