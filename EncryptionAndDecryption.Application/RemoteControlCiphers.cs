using EncryptionAndDecryption.Application.Ciphers;

namespace EncryptionAndDecryption.Application
{
    public abstract class RemoteCiphers
    {
        protected ICipher _cipher;

        public RemoteCiphers(ICipher cipher)
        {
            _cipher = cipher;
        }

        public abstract void Encrypted();
        public abstract void Decrypted();
        //public abstract void Shift();
    }
}