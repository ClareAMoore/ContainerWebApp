using System;
using System.Collections.Generic;
using Xunit;

namespace ContainerWebApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Empty(new List<string>());
        }
    }
}
