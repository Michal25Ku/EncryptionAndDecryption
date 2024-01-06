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
            var caesarCipherRemoteControl = new CaesarCipherRemoteControl(mockCaesarCipher.Object);

            caesarCipherRemoteControl.ToDecrypt(testText);

            mockCaesarCipher.Verify(x => x.Decrypt(testText, 0));
        }

        [TestMethod]
        public void ToEncryptMethodTest_1Parameter_ShouldCalledEncryptMethodInCaesarCipherClass()
        {
            var mockCaesarCipher = new Mock<ICipher>();
            var caesarCipherRemoteControl = new CaesarCipherRemoteControl(mockCaesarCipher.Object);

            caesarCipherRemoteControl.ToEncrypt(testText);

            mockCaesarCipher.Verify(x => x.Encrypt(testText, 0));
        }

        [TestMethod]
        public void ToDecryptMethodTest_2Parameter_ShouldCalledDecryptMethodInCaesarCipherClass()
        {
            var mockCaesarCipher = new Mock<ICipher>();
            var caesarCipherRemoteControl = new CaesarCipherRemoteControl(mockCaesarCipher.Object);

            caesarCipherRemoteControl.ToDecrypt(testText, 1);

            mockCaesarCipher.Verify(x => x.Decrypt(testText, 1));
        }

        [TestMethod]
        public void ToEncryptMethodTest_2Parameter_ShouldCalledEncryptMethodInCaesarCipherClass()
        {
            var mockCaesarCipher = new Mock<ICipher>();
            var caesarCipherRemoteControl = new CaesarCipherRemoteControl(mockCaesarCipher.Object);

            caesarCipherRemoteControl.ToEncrypt(testText, 1);

            mockCaesarCipher.Verify(x => x.Encrypt(testText, 1));
        }

        [TestMethod]
        public void ShowDecryptedTextMethodTest_ShouldReturnTextFromCaesarCipherClass()
        {
            string test;

            _caesarCipherRemoteControl.ToDecrypt("uęśu234", 1);
            test = _caesarCipherRemoteControl.ShowDecryptedText();

            Assert.AreEqual(testText.ToLower(), test);
        }

        [TestMethod]
        public void ShowEncryptedTextMethodTest_ShouldReturnTextFromCaesarCipherClass()
        {
            string test;

            _caesarCipherRemoteControl.ToEncrypt(testText, 1);
            test = _caesarCipherRemoteControl.ShowEncryptedText();

            Assert.AreEqual("uęśu234", test);
        }

        [TestMethod]
        public void ToSetAlphabetTestMethod_ShouldCalledSetAlphabetMethodInCaesarCipherClass()
        {
            var mockCaesarCipher = new Mock<ICipher>();
            var caesarCipherRemoteControl = new CaesarCipherRemoteControl(mockCaesarCipher.Object);

            caesarCipherRemoteControl.ToSetAlphabet("En");

            mockCaesarCipher.Verify(x => x.SetAlphabet("En"));
        }
    }
}
