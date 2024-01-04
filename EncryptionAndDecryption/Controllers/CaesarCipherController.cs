using EncryptionAndDecryption.Application.Ciphers;
using EncryptionAndDecryption.Models;
using Microsoft.AspNetCore.Mvc;

namespace EncryptionAndDecryption.Controllers
{
    public class CaesarCipherController : Controller
    {
        private readonly ICipher _caesarCipher;

        public CaesarCipherController(ICipher caesarCipher)
        {
            _caesarCipher = caesarCipher;
        }

        public IActionResult CaesarCipherForm()
        {
            return View(_caesarCipher);
        }

        [HttpPost]
        public IActionResult Encrypt(string text, int shift)
        {
            _caesarCipher.SetAdditionalFunctional();
            _caesarCipher.Encrypt(text);

            return View("CaesarCipherForm", _caesarCipher);
        }

        [HttpPost]
        public IActionResult Decrypt(string text, int shift)
        {
            _caesarCipher.SetAdditionalFunctional();
            _caesarCipher.Decrypt(text);

            return View("CaesarCipherForm", _caesarCipher);
        }
    }
}
