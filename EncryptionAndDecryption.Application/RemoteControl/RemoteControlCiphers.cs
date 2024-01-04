using EncryptionAndDecryption.Application.Ciphers;

namespace EncryptionAndDecryption.Application.RemoteControl
{
    public abstract class RemoteControlCiphers
    {
        protected ICipher _cipher;

        public RemoteControlCiphers(ICipher cipher)
        {
            _cipher = cipher;
        }

        public abstract void ToEncrypt();
        public abstract void ToDecrypt();
        public abstract void ToSetAlphabet();
    }
}