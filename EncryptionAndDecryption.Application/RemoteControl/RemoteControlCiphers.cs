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

        public virtual void ToEncrypt(string text)
        {
            _cipher.Encrypt(text);
        }
        public virtual string ShowEncryptedText() => _cipher.EncryptedText;

        public virtual void ToDecrypt(string text)
        {
            _cipher.Decrypt(text);
        }
        public virtual string ShowDecryptedText() => _cipher.DecryptedText;

        public virtual char[] ToGetCurrentAlphabet() => _cipher.GetCurrentAlphabet();
    }
}