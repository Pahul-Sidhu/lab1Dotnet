using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab1.Models;

namespace lab1.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int Year { get; set; }

        [TempData]
        public required string ZodiacSign { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if(Year < 1900){
                    ZodiacSign = "";
                }else{
                    ZodiacSign = Utils.GetZodiac(Year);
                }
                
                return Page();
            }
            return BadRequest();
        }
    }
}
