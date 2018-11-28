using MobileStore.Models;
using MobileStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace MobileStore.Controllers
{
    [RoutePrefix("api/ver1/mobiledevices")]
    public class MobileDeviceController : ApiController
    {
        private MobileDeviceService _mobileDeviceService;
        public MobileDeviceController()
        {
            _mobileDeviceService = new MobileDeviceService();
        }

        [HttpGet]
        [Route("getAll")]
        [ResponseType(typeof(List<MobileDevice>))]
        public async Task<IHttpActionResult> GetMobileDevices()
        {
            try
            {
                var mobileDevices = _mobileDeviceService.GetAllMobileDevices();

                return Ok(mobileDevices);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("{id}")]
        [ResponseType(typeof(MobileDevice))]
        public async Task<IHttpActionResult> GetMobileDevice(int id)
        {
            try
            {
                var mobileDevice = _mobileDeviceService.GetMobileDevice(id);

                return Ok(mobileDevice);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
