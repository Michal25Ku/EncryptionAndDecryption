using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Ciphers
{
    public interface ICipher
    {
        string EncryptedText(string explicitText);
        string DecryptedText(string encryptedText);
    }
}
