﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalDataLibary;

namespace PharmaTests
{
    [TestClass]
    public class MongoCrudUnitTest
    {
        [TestMethod]
        public void test_insert_exists()
        {
            //given
            MongoConnector mongo = new MongoConnector("mflix");
            LocationDataModel locData = new LocationDataModel();
            locData.primaryAddress = "4000 Hulen Pl";
            locData.city = "Fort Worth";
            locData.state = "Texas";
            locData.postalCode = "76107";
            locData.country = "United States";

            //when
            mongo.InsertRecord<LocationDataModel>("LocationData", locData);

            //then
        }
    }
}
