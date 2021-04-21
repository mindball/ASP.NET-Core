using AnchorTagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AnchorTagHelper.Controllers
{
    public class SpeakerController : Controller
    {      

        [Route("Speaker/{id:int}")]
        public IActionResult Detail(int id)
        {
            var newSpeakerViewModel = new SpeakerViewModel();
            newSpeakerViewModel.SpeakerId = id;
            return View(newSpeakerViewModel);
        }

        public IActionResult Detail(int speakerId, string speakerName)
        {
            var newSpeakerViewModel = new SpeakerViewModel();
            newSpeakerViewModel.SpeakerId = speakerId;
            newSpeakerViewModel.Name = speakerName;
            return View(newSpeakerViewModel);
        }

        [Route("/Speaker/Evaluations",
               Name = "speakerevals")]
        public IActionResult Evaluations() => View();

        [Route("/Speaker/EvaluationsCurrent",
               Name = "speakerevalscurrent")]
        public IActionResult Evaluations(
            int speakerId,
            string speakerName,
            bool currentYear)
        {
            var newSpeakerViewModel = new SpeakerViewModel();
            newSpeakerViewModel.SpeakerId = speakerId;
            newSpeakerViewModel.Name = speakerName;
            newSpeakerViewModel.CurrentYear = currentYear;
            return View(newSpeakerViewModel);
        }


        public IActionResult Index() => View();
    }    
}
