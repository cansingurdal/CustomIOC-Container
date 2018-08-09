using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ioc_Example.Models;
using Ninject;

namespace Ioc_Example.Controllers
{
    public class DefaultController : ApiController
    {
        public IHttpActionResult Get()
        {
            BildirimManager bildirim = NinjectHelper.Kernel.Get<BildirimManager>();
            bildirim.BildirimYap();
            return Ok();
        }
    }
}
