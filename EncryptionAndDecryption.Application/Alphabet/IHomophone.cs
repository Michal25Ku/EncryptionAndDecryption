using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Alphabet
{
    public interface IHomophone
    {
        public char[] AllHomophone();
        public Dictionary<char, char[]> GetLetterWithTheirHomophone(char[] alphabetWithNumberOfHomophone);
    }
}
