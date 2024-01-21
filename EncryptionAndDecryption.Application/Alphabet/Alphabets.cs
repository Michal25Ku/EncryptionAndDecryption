using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Alphabet
{
    public class Alphabets : IAlphabet
    {
        public static Dictionary<string, char[]> AlphabetList { get; private set; } = new Dictionary<string, char[]>()
        {
            {
                "En", new char[]
                {
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
                    'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                }
            },
            {
                "Pl", new char[]
                {
                    'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n',
                    'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ź', 'ż',
                }
            },
            {
                "HomophonePl", new char[]
                {
                    'a', '9', 'ą', '1', 'b', '1', 'c', '4', 'ć', '1', 'd', '3', 'e', '8', 'ę', '1', 'f', '1', 'g', '1', 'h', '1', 
                    'i', '8', 'j', '2', 'k', '4', 'l', '2', 'ł', '2', 'm', '3', 'n', '6', 'ń', '1', 'o', '8', 'ó', '1', 'p', '3',
                    'q', '1', 'r', '5', 's', '4', 'ś', '1', 't', '4', 'u', '3', 'v', '1', 'w', '5', 'x', '1', 'y', '4', 'z', '6',
                    'ź', '1', 'ż', '1'
                }
            }
        };

        public void AddNewAlphabet(string alphabetName, char[] alphabet)
        {
            AlphabetList.Add(alphabetName, alphabet);
        }

        public char[] FoundAlphabet(string alphabetName) => AlphabetList[alphabetName];
    }
}
