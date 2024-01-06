using EncryptionAndDecryption.Application.Ciphers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.RemoteControl
{
    public class CaesarCipherRemoteControl : RemoteControlCiphers
    {
        public CaesarCipherRemoteControl(ICipher cipher) : base(cipher)
        {
        }

        public override string ShowDecryptedText() => _cipher.DecryptedText;

        public override string ShowEncryptedText() => _cipher.EncryptedText;

        public override void ToDecrypt(string text)
        {
            ToDecrypt(text, 0);
        }

        public void ToDecrypt(string text, int shift)
        {
            _cipher.Decrypt(text, shift);
        }

        public override void ToEncrypt(string text)
        {
            ToEncrypt(text, 0);
        }

        public void ToEncrypt(string text, int shift)
        {
            _cipher.Encrypt(text, shift);
        }

        public override void ToSetAlphabet(string alphabetName)
        {
            _cipher.SetAlphabet(alphabetName);
        }
    }
}
