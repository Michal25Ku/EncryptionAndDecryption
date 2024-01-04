using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Alphabet
{
    public interface IAlphabet
    {
        public void AddNewAlphabet(string alphabetName, char[] alphabet);
        public char[] FoundAlphabet(string alphabetName);
    }
}
