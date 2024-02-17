namespace EncryptionAndDecryption.Models.Services.AlphabetServices
{
    public class AlphabetService : IAlphabetService
    {
        private Dictionary<int, Alphabet> _alphabets = new Dictionary<int, Alphabet>()
        {
            {
                1, new Alphabet
                {
                    AlphabetId = 1,
                    AlphabetName = "Polish",
                    AlphabetChars = "aąbcćdeęfghijklłoópqrsśtuvwxyzźż"
                }
            },
            {
                2, new Alphabet
                {
                    AlphabetId = 2,
                    AlphabetName = "English",
                    AlphabetChars = "abcdefghijklopqrstuvwxyz"
                }
            },
        };

        public int AddNewAlphabet(Alphabet alphabet)
        {
            int id = _alphabets.Keys.Count != 0 ? _alphabets.Keys.Max() : 0;
            alphabet.AlphabetId = id + 1;
            alphabet.AlphabetChars = new string(alphabet.AlphabetChars.Distinct().ToArray());
            _alphabets.Add(alphabet.AlphabetId, alphabet);
            return alphabet.AlphabetId;
        }

        public void DeleteAlphabet(int id)
        {
            _alphabets.Remove(id);
        }

        public Alphabet? GetAlphabet(int id)
        {
            return _alphabets[id];
        }

        public List<Alphabet> GetAllAlphabets()
        {
            return _alphabets.Values.ToList();
        }

        public void UpdateAlphabet(Alphabet alphabet)
        {
            alphabet.AlphabetChars = new string(alphabet.AlphabetChars.Distinct().ToArray());
            _alphabets[alphabet.AlphabetId] = alphabet;
        }
    }
}