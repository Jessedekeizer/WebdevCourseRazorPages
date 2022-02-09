using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Org.BouncyCastle.Ocsp;

namespace Exercises.Pages.Lesson1
{
    public class Assignment1 : PageModel
    {
        [BindProperty(SupportsGet = true)] public int Home { get; set; }
        [BindProperty(SupportsGet = true)] public int Away { get; set; }

        

        public void OnGet()
        {
            
        }
        
        // public void OnGet([FromQuery] string count, [FromQuery] int amount)
        // {
        //     if (count == "HomeInc")
        //     {
        //         Home = amount;
        //         Home++;
        //     }
        //     if (count == "HomeDec")
        //     {
        //         Home = amount;
        //         Home--;
        //     }
        //     if (count == "AwayInc")
        //     {
        //         Away = amount; 
        //         Away++;
        //     }
        //     if (count == "AwayDec")
        //     {
        //         Away = amount; 
        //         Away--;
        //     }
        // }
        
        // public void OnGet()
        // {
        //     if (Request.Query.ContainsKey("HomeInc"))
        //     {
        //         Home = Convert.ToInt32(Request.Query["HomeInc"].First());
        //         Home++;
        //     }
        //     if (Request.Query.ContainsKey("HomeDec"))
        //     {
        //         Home = Convert.ToInt32(Request.Query["HomeDec"].First());
        //         Home--;
        //     }
        //     if (Request.Query.ContainsKey("AwayInc"))
        //     {
        //         Away = Convert.ToInt32(Request.Query["AwayInc"].First()); 
        //         Away++;
        //     }
        //     if (Request.Query.ContainsKey("AwayDec"))
        //     {
        //         Away = Convert.ToInt32(Request.Query["AwayDec"].First()); 
        //         Away--;
        //     }
        // }
    }
}
