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

        void Encrypt(string plainText);
        void Decrypt(string encryptedText);
        char[] GetCurrentAlphabet();
        void Action(object obj);
    }
}
