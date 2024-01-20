using EncryptionAndDecryption.Application.Alphabet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Ciphers
{
    public interface ICipher
    {
        string? EncryptedText { get; set; }
        string? DecryptedText { get; set; }

        void Encrypt(string plainText, int shift = 0);
        void Decrypt(string encryptedText, int shift = 0);
        char[] GetCurrentAlphabet();
        void Action(object obj);
    }
}
