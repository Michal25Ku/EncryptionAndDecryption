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

        public void CreateKey()
        {
            _cipher.Action(this);
        }
    }
}
