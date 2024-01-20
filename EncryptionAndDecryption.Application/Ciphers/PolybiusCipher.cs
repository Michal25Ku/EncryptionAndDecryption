using EncryptionAndDecryption.Application.Alphabet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.Ciphers
{
    public class PolybiusCipher : ICipher
    {
        public IAlphabet Alphabets { get; set; }
        private char[] CurrentAlphabet { get; set; }
        public char[,] Key { get; private set; }

        public PolybiusCipher()
        {
            Alphabets = new Alphabets();
            CurrentAlphabet = Alphabets.FoundAlphabet("Pl");
            Key = CreateKey();
        }

        public string? EncryptedText { get; set; }
        public string? DecryptedText { get; set; }

        public void Decrypt(string encryptedText, int shift = 0)
        {
            if (encryptedText == null || Key is null)
                return;

            string plainText = "";

            for (int i = 0; i < encryptedText.Length; i+=2)
            {
                int row = int.Parse(encryptedText[i].ToString()) - 1;
                int collumn = int.Parse(encryptedText[i + 1].ToString()) - 1;

                plainText += Key[row, collumn];
            }

            DecryptedText = plainText;
        }

        public void Encrypt(string plainText, int shift = 0)
        {
            if (plainText == null || Key is null)
                return;

            var letters = plainText.ToLower().Where(l => char.IsLetter(l) || char.IsNumber(l)).ToArray();
            string encryptedText = "";
            foreach(var l in letters)
            {
                for (int i = 0; i < Key.GetLength(0); i++)
                {
                    for (int j = 0; j < Key.GetLength(1); j++)
                    {
                        if (l == Key[i, j])
                            encryptedText += (i + 1).ToString() + (j + 1).ToString();
                    }
                }
            }

            EncryptedText = encryptedText;
        }

        public char[] GetCurrentAlphabet()
        {
            char[] keyTable = new char[Key.GetLength(0) * Key.GetLength(1) + 2];
            int k = 0;

            for (int i = 0; i < Key.GetLength(0); i++)
            {
                for (int j = 0; j < Key.GetLength(1); j++)
                {
                    keyTable[k] = Key[i, j];
                    k++;
                }
            }

            // On the end of array add number of rows and collumns
            keyTable[k] = (char)Key.GetLength(0);
            keyTable[k += 1] = (char)Key.GetLength(1);

            return keyTable;
        }

        public void Action(object obj)
        {
            Key = CreateKey();
        }

        private char[,] CreateKey()
        {
            char[,] key = new char[NumberOfRowsAndCollumns()[0], NumberOfRowsAndCollumns()[1]];
            char[] shuffledAlphabet = GetShuffledAlphabet();

            int k = 0;
            for (int i = 0; i < key.GetLength(0); i++)
            {
                for (int j = 0; j < key.GetLength(1); j++)
                {
                    if(k > shuffledAlphabet.Length - 1)
                    {
                        key[i, j] = ' ';
                    }
                    else
                    {
                        key[i, j] = shuffledAlphabet[k];
                        k++;
                    }
                }
            }

            return key;
        }

        #region
        private int[] NumberOfRowsAndCollumns()
        {
            int rows = CurrentAlphabet.Length / 5;
            int collums = CurrentAlphabet.Length / 5;

            for (int i = rows; i > 0; i--)
            {
                if (i * collums < CurrentAlphabet.Length)
                {
                    rows = i + 1;
                    break;
                }
                else if (i * collums == CurrentAlphabet.Length)
                {
                    rows = i;
                    break;
                }
            }

            return new int[] { rows, collums };
        }

        private char[] GetShuffledAlphabet()
        {
            char[] shuffledAlphabet = (char[])CurrentAlphabet.Clone();
            Random random = new Random();

            for (int i = shuffledAlphabet.Length - 1; i > 0; i--)
            {
                int losowaPozycja = random.Next(0, i + 1);

                char temp = shuffledAlphabet[i];
                shuffledAlphabet[i] = shuffledAlphabet[losowaPozycja];
                shuffledAlphabet[losowaPozycja] = temp;
            }

            return shuffledAlphabet;
        }
        #endregion
    }
}