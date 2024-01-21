using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application
{
    public static class ExtensionMethods
    {
        public static Array GetShuffledArray(this Array array)
        {
            char[] shuffledArray = (char[])array.Clone();
            Random random = new Random();

            for (int i = shuffledArray.Length - 1; i > 0; i--)
            {
                int randomPosition = random.Next(0, i + 1);

                char temp = shuffledArray[i];
                shuffledArray[i] = shuffledArray[randomPosition];
                shuffledArray[randomPosition] = temp;
            }

            return shuffledArray;
        }
    }
}
