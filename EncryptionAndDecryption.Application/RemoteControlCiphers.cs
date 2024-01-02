using EncryptionAndDecryption.Application.Ciphers;

namespace EncryptionAndDecryption.Application
{
    public abstract class RemoteControlCiphers
    {
        protected ICipher _cipher;

        public RemoteControlCiphers(ICipher cipher)
        {
            _cipher = cipher;
        }

        public abstract void Encrypted();
        public abstract void Decrypted();
        //public abstract void Shift();
    }
}