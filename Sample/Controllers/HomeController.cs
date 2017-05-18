using Amazon.Util;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var properties = new Dictionary<string, object>();
            properties.Add("MachineName", System.Environment.MachineName);
            properties.Add("InstanceId", EC2InstanceMetadata.InstanceId);
            properties.Add("InstanceType", EC2InstanceMetadata.InstanceType);
            properties.Add("AmiId", EC2InstanceMetadata.AmiId);

            return View(properties);
        }
    }
}