using System;
using System.Collections.Generic;
using Exercises.Pages.Lesson1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Exercises.Pages.Lesson1
{
    public class Assignment5 : PageModel
    {
        public class MoodCounter {
            public int Happy { get; set; }
            public int Disappointed { get; set; }
            public int Angry { get; set; }
        }
        public List<MoodCounter> Moodcounters { get; set; }
        public void OnPostHappy()
        {
            MoodCounter deserializedMoodCounter = JsonConvert.DeserializeObject<MoodCounter>(Request.Cookies[json]);

            Moodcounters = new List<MoodCounter>();
            var moodcounter = new MoodCounter();
            moodcounter.Happy++;
            Moodcounters.Add(moodcounter);
            
            
            string counterStr = Request.Cookies["Dingen", json];
            if (counterStr == null) //cookie is not set (first time request or after reset)
            { 
                string json = JsonConvert.SerializeObject(Moodcounters);
                Response.Cookies.Append(json)
            }
        }
    }
}
