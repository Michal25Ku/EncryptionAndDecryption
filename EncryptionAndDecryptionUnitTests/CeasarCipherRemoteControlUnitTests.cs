using EncryptionAndDecryption.Application.Ciphers;
using EncryptionAndDecryption.Application.RemoteControl;
using Moq;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryptionUnitTests
{
    [TestClass]
    public class CeasarCipherRemoteControlUnitTests
    {
        CaesarCipher caesarCipher;
        CaesarCipherRemoteControl _caesarCipherRemoteControl;

        string testText = "Test123";

        public CeasarCipherRemoteControlUnitTests()
        {
            caesarCipher = new CaesarCipher();

            _caesarCipherRemoteControl = new CaesarCipherRemoteControl(caesarCipher);
        }

        [TestMethod]
        public void ToDecryptMethodTest_1Parameter_ShouldCalledDecryptMethodInCaesarCipherClass()
        {
            var mockCaesarCipher = new Mock<ICipher>();

            _caesarCipherRemoteControl.ToDecrypt(testText);

            mockCaesarCipher.Verify(x => x.Decrypt(testText));
        }

        [TestMethod]
        public void ToEncryptMethodTest_1Parameter_ShouldCalledEncryptMethodInCaesarCipherClass()
        {
            var mockCaesarCipher = new Mock<ICipher>();

            _caesarCipherRemoteControl.ToEncrypt(testText);

            mockCaesarCipher.Verify(x => x.Encrypt(testText));
        }

        [TestMethod]
        public void ToDecryptMethodTest_2Parameter_ShouldCalledDecryptMethodInCaesarCipherClass()
        {
            var mockCaesarCipher = new Mock<ICipher>();

            _caesarCipherRemoteControl.ToDecrypt(testText, 1);

            Assert.AreEqual(1, caesarCipher.Shift);
            mockCaesarCipher.Verify(x => x.Decrypt(testText));
        }

        [TestMethod]
        public void ToEncryptMethodTest_2Parameter_ShouldCalledEncryptMethodInCaesarCipherClass()
        {
            var mockCaesarCipher = new Mock<ICipher>();

            _caesarCipherRemoteControl.ToEncrypt(testText, 1);
            Assert.AreEqual(1, caesarCipher.Shift);

            mockCaesarCipher.Verify(x => x.Encrypt(testText));
        }

        [TestMethod]
        public void ShowDecryptedTextMethodTest_ShouldReturnTextFromCaesarCipherClass()
        {
            string test;

            _caesarCipherRemoteControl.ToDecrypt(testText, 1);
            test = _caesarCipherRemoteControl.ShowDecryptedText();

            Assert.AreEqual(testText, "śdrś012");
        }

        [TestMethod]
        public void ShowEncryptedTextMethodTest_ShouldReturnTextFromCaesarCipherClass()
        {
            string test;

            _caesarCipherRemoteControl.ToEncrypt("śdrś012", 1);
            test = _caesarCipherRemoteControl.ShowEncryptedText();

            Assert.AreEqual("śdrś012", testText);
        }

        [TestMethod]
        public void ToSetAlphabetTestMethod_ShouldCalledSetAlphabetMethodInCaesarCipherClass()
        {
            var mockCaesarCipher = new Mock<ICipher>();

            _caesarCipherRemoteControl.ToSetAlphabet("En");

            mockCaesarCipher.Verify(x => x.SetAlphabet("En"));
        }
    }
}
