using EncryptionAndDecryption.Application.Ciphers;
using EncryptionAndDecryption.Application.RemoteControl;
using EncryptionAndDecryption.Models;
using Microsoft.AspNetCore.Mvc;

namespace EncryptionAndDecryption.Controllers
{
    public class CaesarCipherController : Controller
    {
        private readonly CaesarCipherRemoteControl _caesarCipherRemoteControl;

        public CaesarCipherController(IServiceProvider serviceProvider)
        { 
            _caesarCipherRemoteControl = new CaesarCipherRemoteControl(serviceProvider.GetRequiredService<CaesarCipher>());
        }

        public IActionResult CaesarCipherForm()
        {
            return View(_caesarCipherRemoteControl);
        }

        [HttpPost]
        public IActionResult Encrypt(string text, int shift)
        {
            _caesarCipherRemoteControl.ToEncrypt(text, shift);

            return View("CaesarCipherForm", _caesarCipherRemoteControl);
        }

        [HttpPost]
        public IActionResult Decrypt(string text, int shift)
        {
            _caesarCipherRemoteControl.ToDecrypt(text, shift);

            return View("CaesarCipherForm", _caesarCipherRemoteControl);
        }
    }
}
