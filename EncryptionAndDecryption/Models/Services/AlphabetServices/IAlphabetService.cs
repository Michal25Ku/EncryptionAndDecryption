namespace EncryptionAndDecryption.Models.Services.AlphabetServices
{
    public interface IAlphabetService
    {
        int AddNewAlphabet(Alphabet alphabet);
        void DeleteAlphabet(int id);
        Alphabet GetAlphabet(int id);
        List<Alphabet> GetAllAlphabets();
        void UpdateAlphabet(Alphabet alphabet);
    }
}
