using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalDataLibary;

namespace PharmaTests
{
    [TestClass]
    public class PersonalDataUnitTest
    {
        [TestMethod]
        public void test_givenValidLastName_lastNameSet()
        {
            //given
            MongoCRUD mongo = new MongoCRUD("mflix");
            

            //when

            //then
        }

        public void test_givenNumbers__lastNameNotSet()
        {
            //given
                //personalData object created

            //when
                //personalData.setLastName

            //then
               //assert error
        }

    }
}
