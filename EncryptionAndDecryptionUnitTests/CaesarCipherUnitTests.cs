using EncryptionAndDecryption.Application.Alphabet;
using EncryptionAndDecryption.Application.Ciphers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryptionUnitTests
{
    [TestClass]
    public class CaesarCipherUnitTests
    {
        CaesarCipher _caesarCipher = new CaesarCipher();

        [TestMethod]
        public void CaesarCipherConstructorTest_ShouldSetShiftTo0_CreateNewInstanceAlphabetsClass_SetDafaultAlphabetToPolish()
        {
            CaesarCipher testCaesarCipher = new CaesarCipher();

            Assert.AreEqual(0, testCaesarCipher.Shift);
            Assert.IsTrue(testCaesarCipher.Alphabets is Alphabets);
            Assert.IsTrue(testCaesarCipher.CurrentAlphabet.Equals(testCaesarCipher.Alphabets.FoundAlphabet("Pl")));
        }

        [DataTestMethod]
        [DataRow(1, "uęyu234")]
        [DataRow(2, "vfzv345")]
        [DataRow(3, "wgźw456")]
        public void DecryptMethodTest_Decrypted_ShouldReturnStringOfDecryptedCryptogram(int shift, string cryptogram)
        {
            string result = "text123";

            _caesarCipher.Shift = shift;
            _caesarCipher.Decrypt(cryptogram);

            Assert.AreEqual(result, _caesarCipher.DecryptedText);
        }

        [DataTestMethod]
        [DataRow(1, "text123", "uęyu234")]
        [DataRow(2, "Test", "vftv")]
        [DataRow(3, "someThinG", "uqogwklój")]
        public void EncryptMethodTest_Encrypted_ShouldReturnStringOfEncryptedPlainText(int shift, string cryptogram, string expected)
        {
            _caesarCipher.Shift = shift;
            _caesarCipher.Encrypt(cryptogram);

            Assert.AreEqual(expected, _caesarCipher.EncryptedText);
        }

        [TestMethod]
        public void SetAlphabetMethodTest_ShouldSetCurrentAlphabet()
        {
            _caesarCipher.SetAlphabet("En");

            Assert.IsTrue(_caesarCipher.CurrentAlphabet.Equals(_caesarCipher.Alphabets.FoundAlphabet("En")));
        }
    }
}
