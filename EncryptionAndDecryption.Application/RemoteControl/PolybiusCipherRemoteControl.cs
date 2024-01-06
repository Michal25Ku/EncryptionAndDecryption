using EncryptionAndDecryption.Application.Ciphers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.RemoteControl
{
    public class PolybiusCipherRemoteControl : RemoteControlCiphers
    {
        public PolybiusCipherRemoteControl(ICipher cipher) : base(cipher)
        {
        }

        public override string ShowDecryptedText()
        {
            throw new NotImplementedException();
        }

        public override string ShowEncryptedText()
        {
            throw new NotImplementedException();
        }

        public override void ToDecrypt(string text)
        {
            throw new NotImplementedException();
        }

        public override void ToEncrypt(string text)
        {
            throw new NotImplementedException();
        }

        public override void ToSetAlphabet(string alphabetName)
        {
            throw new NotImplementedException();
        }
    }
}
