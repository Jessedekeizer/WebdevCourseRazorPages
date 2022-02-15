using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment3 : PageModel
    {
        public Double Result { get; set; }

        public void OnPostAdd([FromForm] double previousresult, double input)
        {
            Result = previousresult + input;
        }
        public void OnPostSub([FromForm] int previousresult, int input)
        {
            Result = previousresult - input;
        }
        public void OnPostMul([FromForm] int previousresult, int input)
        {
            Result = previousresult * input;
        }
        public void OnPostDiv([FromForm] int previousresult, int input)
        {
            Result = previousresult / input;
        }
    }
}
