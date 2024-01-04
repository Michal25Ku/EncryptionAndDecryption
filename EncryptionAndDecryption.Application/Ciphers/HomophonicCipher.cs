using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Ciphers
{
    public class HomophonicCipher : ICipher
    {
        public string? EncryptedText { get; set; }
        public string? DecryptedText { get; set; }

        public void Decrypt(string encryptedText)
        {
            throw new NotImplementedException();
        }

        public void Encrypt(string plainText)
        {
            throw new NotImplementedException();
        }

        public void SetAdditionalFunctional(int? shift)
        {
            throw new NotImplementedException();
        }

        public void SetAlphabet(string AlhpabetName)
        {
            throw new NotImplementedException();
        }
    }
}
