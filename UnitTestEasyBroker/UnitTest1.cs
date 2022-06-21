using EasyBroker.Controllers;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTestEasyBroker
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public async Task Test1Async()
        {
           
            var controller = new PropertiesController();
            var result = await controller.GetAsync();
            Assert.IsNotEmpty(result.ToString());
        }
    }
}