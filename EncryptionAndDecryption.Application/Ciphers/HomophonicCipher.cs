using EncryptionAndDecryption.Application.Alphabet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Ciphers
{
    public class HomophonicCipher : ICipher
    {
        //public IAlphabet Alphabets { get; set; }
        public IHomophone Homophones { get; set; }

        public char[] AlphabetWithHomophonesNumber { get; set; }

        public Dictionary<char, char[]> LettersWithRandomHomophones { get; private set; }

        public HomophonicCipher()
        {
            //Alphabets = new Alphabets();
            Homophones = new Homophone();

            //AlphabetWithHomophonesNumber = Alphabets.FoundAlphabet("HomophonePl");

            LettersWithRandomHomophones = Homophones.GetLetterWithTheirHomophone(AlphabetWithHomophonesNumber);
        }

        public string? EncryptedText { get; set; }
        public string? DecryptedText { get; set; }

        public void Action(object obj)
        {
            return;
        }

        public void Decrypt(string encryptedText)
        {
            if (encryptedText == null)
                return;

            var letters = encryptedText.ToArray();
            string decryptedText = "";
            foreach(var l in letters)
            {
                bool found = false;

                foreach(var entry in LettersWithRandomHomophones)
                {
                    if(entry.Value.Contains(l))
                    {
                        decryptedText += entry.Key;
                        found = true;
                        break;
                    }
                }

                if(!found)
                {
                    decryptedText += l;
                }
            }

            DecryptedText = decryptedText;
        }

        public void Encrypt(string plainText)
        {
            if (plainText == null)
                return;

            Random random = new Random();
            var letters = plainText.ToLower().Where(l => char.IsLetter(l) || char.IsNumber(l)).ToArray();
            string encryptedText = "";

            foreach(var l in letters)
            {
                char[] homophones = LettersWithRandomHomophones[l];
                int i = random.Next(0, homophones.Length);

                encryptedText += homophones[i];
            }

            EncryptedText = encryptedText;
        }

        public char[] GetCurrentAlphabet() => AlphabetWithHomophonesNumber;
    }
}
