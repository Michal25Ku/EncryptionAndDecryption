using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Ciphers
{
    public class CaesarCipher : ICipher
    {
        public string? Text { get; set; }
        public int Shift { get; set; } = 0;

        public string? EncryptedText { get; set; }
        public string? DecryptedText { get; set; }

        public void Decrypt(string encryptedText, int shift)
        {
            DecryptedText = "costam";
        }

        public void Encrypt(string plainText, int shift)
        {
            EncryptedText = "szaszyfrowane costam";
        }
    }
}
