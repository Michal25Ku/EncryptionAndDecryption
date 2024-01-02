using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Ciphers
{
    public interface ICipher
    {
        string? Text { get; set; }
        int Shift { get; set; }

        string? EncryptedText { get; set; }
        string? DecryptedText { get; set; }

        void Encrypt(string plainText, int shift);
        void Decrypt(string encryptedText, int shift);
    }
}
