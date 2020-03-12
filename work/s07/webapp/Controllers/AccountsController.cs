using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapp.Models;
using webapp.Services;

namespace webapp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        public AccountsController(JsonFileAccountService accountService)
        {
            AccountService = accountService;
        }

         [HttpGet("{accNbr}")]
         [ProducesResponseType(StatusCodes.Status404NotFound)]
         public ActionResult<Account> GetById(int accNbr)
        {

            Account result = null;

            var accounts = AccountService.GetAccounts();
            foreach (var account in accounts){
            if(account.Number == accNbr){
            result = account;
            }

            if (account == null)
            {
                return NotFound();
            }
                    
        }
        return result;
    }
        

        public JsonFileAccountService AccountService { get; }
        

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return AccountService.GetAccounts();
        }
    }
}