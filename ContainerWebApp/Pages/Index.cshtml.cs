﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContainerWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }        

        public async Task<int> OnPostAddMessageAsync()
        {
            return 47;
        }
    }
}
