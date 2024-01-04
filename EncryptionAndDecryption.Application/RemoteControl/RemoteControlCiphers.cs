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

        public abstract void ToEncrypt(string text);
        public abstract string ShowEncryptedText();
        public abstract void ToDecrypt(string text);
        public abstract string ShowDecryptedText();
        public abstract void ToSetAlphabet();
    }
}