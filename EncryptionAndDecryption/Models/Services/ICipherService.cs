namespace EncryptionAndDecryption.Models.Services
{
    public interface ICipherService 
    {
        string Encrypt(string plainText);
        string Decrypt(string encryptedText);
        string SetCurrentAlpabet(string alphabetName);
    }
}
