using EncryptionAndDecryption.Application.Ciphers;
using EncryptionAndDecryption.Application.RemoteControl;
using Moq;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryptionUnitTests.RemoteControl
{
    [TestClass]
    public class CeasarCipherRemoteControlUnitTests
    {
        CaesarCipher caesarCipher;
        CaesarCipherRemoteControl _caesarCipherRemoteControl;

        string testText = "Test";

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

            mockCaesarCipher.Verify(x => x.Decrypt(testText));
        }

        [TestMethod]
        public void ToEncryptMethodTest_1Parameter_ShouldCalledEncryptMethodInCaesarCipherClass()
        {
            var mockCaesarCipher = new Mock<ICipher>();
            var caesarCipherRemoteControl = new CaesarCipherRemoteControl(mockCaesarCipher.Object);

            caesarCipherRemoteControl.ToEncrypt(testText);

            mockCaesarCipher.Verify(x => x.Encrypt(testText));
        }

        [TestMethod]
        public void ToDecryptMethodTest_2Parameter_ShouldCalledDecryptMethodInCaesarCipherClass()
        {
            var mockCaesarCipher = new Mock<ICipher>();
            var caesarCipherRemoteControl = new CaesarCipherRemoteControl(mockCaesarCipher.Object);

            caesarCipherRemoteControl.ToDecrypt(testText);

            mockCaesarCipher.Verify(x => x.Decrypt(testText));
        }

        [TestMethod]
        public void ToEncryptMethodTest_2Parameter_ShouldCalledEncryptMethodInCaesarCipherClass()
        {
            var mockCaesarCipher = new Mock<ICipher>();
            var caesarCipherRemoteControl = new CaesarCipherRemoteControl(mockCaesarCipher.Object);

            caesarCipherRemoteControl.ToEncrypt(testText);

            mockCaesarCipher.Verify(x => x.Encrypt(testText));
        }

        [TestMethod]
        public void ShowDecryptedTextMethodTest_ShouldReturnTextFromCaesarCipherClass()
        {
            string test;

            _caesarCipherRemoteControl.ToDecrypt("uęśu");
            test = _caesarCipherRemoteControl.ShowDecryptedText();

            Assert.AreEqual(testText.ToLower(), test);
        }

        [TestMethod]
        public void ShowEncryptedTextMethodTest_ShouldReturnTextFromCaesarCipherClass()
        {
            string test;

            _caesarCipherRemoteControl.ToEncrypt(testText);
            test = _caesarCipherRemoteControl.ShowEncryptedText();

            Assert.AreEqual("uęśu", test);
        }
    }
}
