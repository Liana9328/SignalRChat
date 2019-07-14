using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SignalRChat.Pages
{
    public class IndexModel : PageModel
    {
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("Login");
            }
            else
            {
                ModelState.AddModelError("", "Agent number is null.");
                return Page();
            }
        }
    }
}
