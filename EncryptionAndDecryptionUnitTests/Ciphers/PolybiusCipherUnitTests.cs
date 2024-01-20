using EncryptionAndDecryption.Application.Alphabet;
using EncryptionAndDecryption.Application.Ciphers;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryptionUnitTests.Ciphers
{
    [TestClass]
    public class PolybiusCipherUnitTests
    {
        readonly PolybiusCipher polybiusCipher;
        readonly char[,] testKey;

        public PolybiusCipherUnitTests()
        {
            polybiusCipher = new PolybiusCipher();
            testKey = (char[,])polybiusCipher.Key.Clone();
        }

        [TestMethod]
        public void PolybiusCipherConstructorTest_Should_CreateNewInstanceAlphabetsClass_CreateKey()
        {
            PolybiusCipher testPolybiusCipher = new PolybiusCipher();

            Assert.IsTrue(testPolybiusCipher.Alphabets is Alphabets);
            Assert.IsTrue(testPolybiusCipher.Key is not null);
        }

        [DataTestMethod]
        [DataRow("1223")]
        public void DecryptMethodTest_Decrypted_ShouldReturnStringOfDecryptedCryptogram(string cryptogram)
        {
            polybiusCipher.Decrypt(cryptogram);

            string result = testKey[1, 2] + "" + testKey[2, 3];

            Assert.AreEqual(result, polybiusCipher.DecryptedText);
        }

        [DataTestMethod]
        [DataRow("text")]
        [DataRow("Test")]
        [DataRow("someThinG")]
        public void EncryptMethodTest_Encrypted_ShouldReturnStringOfEncryptedPlainText(string cryptogram)
        {
            polybiusCipher.Encrypt(cryptogram);
            polybiusCipher.Decrypt(polybiusCipher.EncryptedText);

            Assert.IsTrue(polybiusCipher.DecryptedText.Equals(cryptogram.ToLower()));
        }

        [TestMethod]
        public void ActionMethod_ThisActionIsForCreatingKey_ShouldCreateNewKeyAndSetThisToKey()
        {
            PolybiusCipher testPolybiusCipher = new PolybiusCipher();
            var oldKey = testPolybiusCipher.Key;
            testPolybiusCipher.Action(null);
            var newKey = testPolybiusCipher.Key;

            Assert.IsFalse(oldKey.Equals(newKey));
        }
    }
}
