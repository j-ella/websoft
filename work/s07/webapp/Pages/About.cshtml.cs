using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using webapp.Models;
using webapp.Services;

namespace webapp.Pages
{
    public class AboutModel : PageModel
    {
        private readonly ILogger<AboutModel> _logger;
        public JsonFileAccountService AccountService;
        
        public IEnumerable<Account> Accounts { get; private set; }

        public AboutModel(
            ILogger<AboutModel> logger,
            JsonFileAccountService accountService
        ) {
            _logger = logger;
            AccountService = accountService;
        }

        public void OnGet()
        {
            Accounts = AccountService.GetAccounts();
        }
    }
}
