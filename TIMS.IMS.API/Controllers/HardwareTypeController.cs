using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TIMS.IMS.Services;
using TIMS.IMS.Entities;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace TIMS.IMS.API.Controllers
{


    public class HardwareTypeController : ApiController
    {
        private readonly IHardwareTypeService hardwareTypeService;
        public HardwareTypeController(IHardwareTypeService hardwareTypeService)
        {
            this.hardwareTypeService = hardwareTypeService;
        }
        [HttpGet]
        [Authorize]
        public HttpResponseMessage Getall()
        {

            //IList<HardwareType> hardwareType = new List<HardwareType>();
            //HardwareType htype = new HardwareType { ID = 1, Description = "Baldes" };
            //hardwareType.Add(htype);
            //return hardwareType.AsEnumerable< HardwareType>();

            IEnumerable<HardwareType> hardwareTypes = hardwareTypeService.GetHardwareType().ToList();

            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            resp.Content = new ObjectContent<IEnumerable<HardwareType>>(
                                    hardwareTypes, new JsonMediaTypeFormatter());
            resp.Headers.ConnectionClose = true;
            resp.Headers.CacheControl = new CacheControlHeaderValue();
            resp.Headers.CacheControl.Public = true;
            return resp;

        }
    }
}
