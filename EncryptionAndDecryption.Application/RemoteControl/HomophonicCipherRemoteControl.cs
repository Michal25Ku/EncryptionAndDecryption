using EncryptionAndDecryption.Application.Ciphers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption.Application.RemoteControl
{
    public class HomophonicCipherRemoteControl : RemoteControlCiphers
    {
        public HomophonicCipherRemoteControl(ICipher cipher) : base(cipher)
        {
        }

        public override void ToDecrypt()
        {
            throw new NotImplementedException();
        }

        public override void ToEncrypt()
        {
            throw new NotImplementedException();
        }

        public override void ToSetAlphabet()
        {
            throw new NotImplementedException();
        }
    }
}
