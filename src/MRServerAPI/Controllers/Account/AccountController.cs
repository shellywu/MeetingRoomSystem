using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SupportLayer.CoreModel;
using SupportLayer.Manager.Account;
using SupportLayer.Manager.Account.Abstraction;
using CommonUtitly;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MRServerAPI.Controllers.Account
{

    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private Model.AccountFaced _accountFaced = null;
        public AccountController()
        {
            _accountFaced = new Model.AccountFaced();
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        //[AllowAnonymous]
        //// POST api/values
        //[HttpPost]
        [ValidationModelActionFilter]
        public IActionResult Post([FromBody]AppUser user)
        {
            if (user.App == null)
            {
                var r = _accountFaced.CreateNewAccount(user);
                return Ok(r);
            }

            var radd = _accountFaced.AddNewAccount(user);
            return Ok(radd);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
