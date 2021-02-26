using System;
using Xunit;
using SimpleAPI.Controllers;
namespace SimpleAPI.test
{
    public class UnitTest1
    {

        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Arpit Nagar", returnValue.Value);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
