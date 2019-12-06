using System;
using System.Collections.Generic;
using Xunit;

namespace Advent.Tests
{
    public class ModuleTests
    {
        [Fact]
        public void TotalFuelRequirement_ReturnsCorrectValue()
        {
            var modules = new []
            {
                new Module { Mass = 14 },
                new Module { Mass = 1969 },
                new Module { Mass = 100756 }
            };

            Assert.Equal(2, modules[0].TotalFuelRequirement);
            Assert.Equal(966, modules[1].TotalFuelRequirement);
            Assert.Equal(50346, modules[2].TotalFuelRequirement);
        }
    }
}
