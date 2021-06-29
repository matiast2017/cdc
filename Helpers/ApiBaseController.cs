using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cdc.Helpers
{
    public abstract class ApiBaseController : ControllerBase
    {
        protected int GetId()
        {
            return int.Parse(User.Claims.Where(x => x.Type == "Id").Select(x => x.Value).FirstOrDefault());
        }
    }
}
