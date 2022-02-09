using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment3 : PageModel
    {
        
        [BindProperty]
        public int InputBindProperty {get; set;}

        public int Output { get; set; }

        public void OnPost([FromForm]string input)
        {
            Output = Convert.ToInt32(input);
        }
    }
}
