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
        public CaesarCipherRemoteControl(ICipher cipher) : base(cipher) { }

        public void SetShift(int shift)
        {
            _cipher.Action(shift);
        }
    }
}
