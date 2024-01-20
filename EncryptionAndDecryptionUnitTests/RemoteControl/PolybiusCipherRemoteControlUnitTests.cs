using EncryptionAndDecryption.Application.Ciphers;
using EncryptionAndDecryption.Application.RemoteControl;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryptionUnitTests.RemoteControl
{
    [TestClass]
    public class PolybiusCipherRemoteControlUnitTests
    {
        readonly ICipher _polybiusCipher;
        readonly PolybiusCipherRemoteControl _polybiusCipherRemoteControl;

        string testText = "Test";

        public PolybiusCipherRemoteControlUnitTests()
        {
            _polybiusCipher = new PolybiusCipher();

            _polybiusCipherRemoteControl = new PolybiusCipherRemoteControl(_polybiusCipher);
        }

        [TestMethod]
        public void ToDecryptMethodTest_ShouldCalledDecryptMethodInPolybiusCipherClass()
        {
            var mockPolybiusCipher = new Mock<ICipher>();
            var polybiusCipherRemoteControl = new PolybiusCipherRemoteControl(mockPolybiusCipher.Object);

            polybiusCipherRemoteControl.ToDecrypt(testText);

            mockPolybiusCipher.Verify(x => x.Decrypt(testText, 0));
        }

        [TestMethod]
        public void ToEncryptMethodTest_ShouldCalledEncryptMethodInPolybiusCipherClass()
        {
            var mockPolybiusCipher = new Mock<ICipher>();
            var polybiusCipherRemoteControl = new CaesarCipherRemoteControl(mockPolybiusCipher.Object);

            polybiusCipherRemoteControl.ToEncrypt(testText);

            mockPolybiusCipher.Verify(x => x.Encrypt(testText, 0));
        }

        [TestMethod]
        public void ShowDecryptedTextMethodTest_ShouldReturnTextFromPolybiusCipherClass()
        {
            string test;

            _polybiusCipherRemoteControl.ToDecrypt("1122");
            test = _polybiusCipherRemoteControl.ShowDecryptedText();

            Assert.AreEqual(_polybiusCipher.DecryptedText, test);
        }

        [TestMethod]
        public void ShowEncryptedTextMethodTest_ShouldReturnTextFromPolybiusCipherClass()
        {
            string test;

            _polybiusCipherRemoteControl.ToEncrypt(testText);
            test = _polybiusCipherRemoteControl.ShowEncryptedText();

            Assert.AreEqual(_polybiusCipher.EncryptedText, test);
        }

        [TestMethod]
        public void CreateKeyMethodTest_ShouldCalledActionMethodInPolybiusCipherClass()
        {
            var mockPolybiusCipher = new Mock<ICipher>();
            var polybiusCipherRemoteControl = new PolybiusCipherRemoteControl(mockPolybiusCipher.Object);

            polybiusCipherRemoteControl.CreateKey();

            mockPolybiusCipher.Verify(x => x.Action(null));
        }
    }
}
