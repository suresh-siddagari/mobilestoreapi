using MobileStore.Models;
using MobileStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace MobileStore.Controllers
{
    [RoutePrefix("api/ver1/mobiledevices")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MobileDeviceController : ApiController
    {
        private MobileDeviceService _mobileDeviceService;
        public MobileDeviceController()
        {
            _mobileDeviceService = new MobileDeviceService();
        }

        /// <summary>
        ///  Get all mobile devices
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Get mobile device by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
