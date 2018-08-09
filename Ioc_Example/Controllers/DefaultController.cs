using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ioc_Example.Models;

namespace Ioc_Example.Controllers
{
    public class DefaultController : ApiController
    {
        public void Get()
        {
            BildirimManager bildirim = BildirimManagerCreator.Create();
            bildirim.BildirimYap();
        }
    }
}
