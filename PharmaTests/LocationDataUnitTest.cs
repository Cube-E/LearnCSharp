using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalDataLibary;

namespace PharmaTests
{
    [TestClass]
    public class LocationDataUnitTest
    {
        [TestMethod]
        public void test_givenValidLastName_lastNameSet()
        {
            //given
            MongoCRUD mongo = new MongoCRUD("mflix");
            LocationDataModel locData = new LocationDataModel();
            locData.primaryAddress = "4000 Hulen Pl";
            locData.city = "Fort Worth";
            locData.state = "Texas";
            locData.postalCode = "76107";
            locData.country = "United States";

            //when
            mongo.InsertRecord("LocationData", locData);

            //then
        }
    }
}
