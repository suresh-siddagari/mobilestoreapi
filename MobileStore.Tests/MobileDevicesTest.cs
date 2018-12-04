using NUnit.Framework;

namespace MobileStore.Tests
{
    [TestFixture]
    public class MobileDevicesTest
    {

        //Unit test for GetDiscountPrice()
        [Test]
        public void MobileDevice_DiscountPrice_Test()
        {
            //Arrange
            MobileStore.Services.MobileDeviceService mobileService = new Services.MobileDeviceService();
            double expectedPrice = 6850;

            //Act
            double actualPrice = mobileService.GetDiscountPrice(7500);

            //Assert
            Assert.That(actualPrice==expectedPrice,"Failed in calcuating discount price");
        }
    }
}
