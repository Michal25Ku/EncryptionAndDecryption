using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Ciphers
{
    public interface IPolybiusExtensionMethods
    {
        public char[,] SetKeyForDecryption(char[] allegedKey);
    }
}
