﻿using System;
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
        };

        public void AddNewAlphabet(string alphabetName, char[] alphabet)
        {
            AlphabetList.Add(alphabetName, alphabet);
        }

        public char[] FoundAlphabet(string alphabetName) => AlphabetList[alphabetName];
    }
}
