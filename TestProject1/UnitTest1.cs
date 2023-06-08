using System.Security.Principal;
using System.Xml.Linq;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1_field()
        {
            try
            {
                driver.FindElement(By.Id("gh-ac"));
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "No element with id hg-ac");
            }

        }

        [Test]
        public void Test2_search()
        {
            try
            {
                driver.FindElement(By.Id("gh-btn"));
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "No element with id hg - btn");
            }

        }
    }
}