using EncryptionAndDecryption.Models;
using EncryptionAndDecryption.Models.Services.AlphabetServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption
{
    public class AlphabetController : Controller
    {
        private readonly IAlphabetService _alphabetService;

        public AlphabetController(IAlphabetService alphabetService)
        {
            _alphabetService = alphabetService;
        }

        [HttpGet]
        public IActionResult AllAlphabets()
        {
            return View(_alphabetService.GetAllAlphabets());
        }

        [HttpGet]
        public IActionResult CreateAlphabet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAlphabet(Alphabet alphabet)
        {
            if(ModelState.IsValid)
            {
                _alphabetService.AddNewAlphabet(alphabet);
                return View("AllAlphabets", _alphabetService.GetAllAlphabets());
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult EditAlphabet(int id)
        {
            var alphabet = _alphabetService.GetAlphabet(id);

            if (alphabet is not null)
            {
                return View(alphabet);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult EditAlphabet(Alphabet alphabet)
        {
            if (ModelState.IsValid)
            {
                _alphabetService.UpdateAlphabet(alphabet);
                return View("AllAlphabets", _alphabetService.GetAllAlphabets());
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult DeleteAlphabet(int id)
        {
            var alphabet = _alphabetService.GetAlphabet(id);

            if (alphabet is not null)
            {
                return View(alphabet);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Delete(Alphabet alphabet)
        {
            _alphabetService.DeleteAlphabet(alphabet.AlphabetId);
            return View("AllAlphabets", _alphabetService.GetAllAlphabets());
        }
    }
}
