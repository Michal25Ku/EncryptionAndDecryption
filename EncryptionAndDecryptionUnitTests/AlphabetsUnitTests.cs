using EncryptionAndDecryption.Application.Alphabet;

namespace EncryptionAndDecryptionUnitTests
{
    [TestClass]
    public class AlphabetsUnitTests
    {
        Alphabets _alphabets = new Alphabets();

        [TestMethod]
        public void AddNewAlphabetMethodTest_AddNewAlpabet_ShouldAddAlphabetToDictionary()
        {
            string testAlphabetName = "NewAlphabet";
            char[] testAlphabet = new char[] { 'a', 'b', 'c', '.' };

            _alphabets.AddNewAlphabet(testAlphabetName, testAlphabet);

            Assert.IsTrue(_alphabets.AlphabetList.ContainsKey(testAlphabetName));
            Assert.IsTrue(_alphabets.AlphabetList[testAlphabetName].Equals(testAlphabet));
        }

        [TestMethod]
        public void FoundAlphabetMethodTest_ShouldReturnCharArray()
        {
            string testAlphabetName = "Test alphabet";
            char[] testAlphabet = new char[] { 'a', 'b', 'c', '.' };
            char[] expectedAlphabet;

            _alphabets.AddNewAlphabet(testAlphabetName, testAlphabet);
            expectedAlphabet = _alphabets.FoundAlphabet(testAlphabetName);

            Assert.IsTrue(expectedAlphabet.Equals(testAlphabet));
        }
    }
}