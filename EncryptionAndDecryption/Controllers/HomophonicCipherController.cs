using EncryptionAndDecryption.Application.Ciphers;
using EncryptionAndDecryption.Application.RemoteControl;
using Microsoft.AspNetCore.Mvc;

namespace EncryptionAndDecryption.Controllers
{
    public class HomophonicCipherController : Controller
    {
        private readonly HomophonicCipherRemoteControl _homophonicCipherRemoteControl;

        public HomophonicCipherController(IServiceProvider serviceProvider)
        {
            _homophonicCipherRemoteControl = new HomophonicCipherRemoteControl(serviceProvider.GetRequiredService<HomophonicCipher>());
        }

        public IActionResult HomophonicCipherForm()
        {
            return View(_homophonicCipherRemoteControl);
        }

        [HttpPost]
        public IActionResult Encrypt(string text)
        {
            _homophonicCipherRemoteControl.ToEncrypt(text);

            return View("HomophonicCipherForm", _homophonicCipherRemoteControl);
        }

        [HttpPost]
        public IActionResult Decrypt(string text)
        {
            _homophonicCipherRemoteControl.ToDecrypt(text);

            return View("HomophonicCipherForm", _homophonicCipherRemoteControl);
        }
    }
}