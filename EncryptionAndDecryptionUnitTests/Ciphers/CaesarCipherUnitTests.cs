using EncryptionAndDecryption.Application.Alphabet;
using EncryptionAndDecryption.Application.Ciphers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryptionUnitTests.Ciphers
{
    [TestClass]
    public class CaesarCipherUnitTests
    {
        CaesarCipher _caesarCipher = new CaesarCipher();

        [TestMethod]
        public void CaesarCipherConstructorTest_ShouldSetShiftTo0_CreateNewInstanceAlphabetsClass_SetDafaultAlphabetToPolish()
        {
            CaesarCipher testCaesarCipher = new CaesarCipher();

            Assert.IsTrue(testCaesarCipher.Alphabets is Alphabets);
            Assert.IsTrue(testCaesarCipher.GetCurrentAlphabet().Equals(testCaesarCipher.Alphabets.FoundAlphabet("Pl")));
        }

        [DataTestMethod]
        [DataRow(1, "uęyu")]
        [DataRow(2, "vfzv")]
        [DataRow(3, "wgźw")]
        public void DecryptMethodTest_Decrypted_ShouldReturnStringOfDecryptedCryptogram(int shift, string cryptogram)
        {
            string result = "text";

            _caesarCipher.Decrypt(cryptogram);

            Assert.AreEqual(result, _caesarCipher.DecryptedText);
        }

        [DataTestMethod]
        [DataRow(1, "text", "uęyu")]
        [DataRow(2, "Test", "vftv")]
        [DataRow(3, "someThinG", "uqogwklój")]
        public void EncryptMethodTest_Encrypted_ShouldReturnStringOfEncryptedPlainText(int shift, string cryptogram, string expected)
        {
            _caesarCipher.Encrypt(cryptogram);

            Assert.AreEqual(expected, _caesarCipher.EncryptedText);
        }
    }
}
