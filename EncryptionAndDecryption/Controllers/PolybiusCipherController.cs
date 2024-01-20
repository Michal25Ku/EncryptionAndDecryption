using EncryptionAndDecryption.Application.Ciphers;
using EncryptionAndDecryption.Application.RemoteControl;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace EncryptionAndDecryption.Controllers
{
    public class PolybiusCipherController : Controller
    {
        private readonly PolybiusCipherRemoteControl _polybiusCipherRemoteControl;

        public PolybiusCipherController(IServiceProvider serviceProvider)
        {
            _polybiusCipherRemoteControl = new PolybiusCipherRemoteControl(serviceProvider.GetRequiredService<PolybiusCipher>());
        }

        public IActionResult PolybiusCipherForm()
        {
            return View(_polybiusCipherRemoteControl);
        }

        [HttpPost]
        public IActionResult Encrypt(string text)
        {
            _polybiusCipherRemoteControl.ToEncrypt(text);

            return View("PolybiusCipherForm", _polybiusCipherRemoteControl);
        }

        [HttpPost]
        public IActionResult CreateKey()
        {
            _polybiusCipherRemoteControl.CreateKey();

            return View("PolybiusCipherForm", _polybiusCipherRemoteControl);
        }

        [HttpPost]
        public IActionResult Decrypt(string text)
        {
            _polybiusCipherRemoteControl.ToDecrypt(text);

            return View("PolybiusCipherForm", _polybiusCipherRemoteControl);
        }
    }
}
