using MobileStore.Models;
using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace MobileStore.Tests
{
    [TestFixture]
    public class MobileDevicesTest
    {



        //Unit test for GetDiscountPrice()
        //Here, we test only discount price logic only
        [Test]
        public void MobileDevice_Calculate_DiscountPrice_Test()
        {
            //Arrange
            MobileStore.Services.MobileDeviceService mobileService = new Services.MobileDeviceService();
            double expectedPrice = 6850;

            //Act
            double actualPrice = mobileService.GetDiscountPrice(7500);

            //Assert
            Assert.That(actualPrice == expectedPrice, "Failed in calcuating discount price");
        }

        //Integration testing
        //Here, we test the flow by getting price through API
        [Test]
        public void MobileDevice_GetDevicePrice_Test()
        {

            //Arrange
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var client = new RestClient("https://mobilestoreapi.azurewebsites.net");
            var request = new RestRequest("api/ver1/mobiledevices/1", Method.GET);
            int expectedPrice = 4999;

            //Act
            // execute the request
             MobileDevice mobileDevice = client.Execute<MobileDevice>(request).Data;

            //Assert
            Assert.AreEqual(expectedPrice, mobileDevice.Price);

        }


    }
}
