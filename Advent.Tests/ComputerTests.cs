using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace Advent.Tests
{
    public class ComputerTests
    {
        [Fact]
        public void RunIntCodeProgram_ReturnsCorrectOutput()
        {
            var pc = new Computer();

            var inputs = new[]
            {
                new[] { 1, 0, 0, 0, 99 },
                new[] { 2,3,0,3,99 },
                new[] { 2,4,4,5,99,0 },
                new[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 }
            };

            Assert.Equal("2,0,0,0,99", string.Join(",", 
                pc.RunIntCodeProgram(inputs[0])
                    .Select(i => i.ToString()))
            );

            Assert.Equal("2,3,0,6,99", string.Join(",",
                pc.RunIntCodeProgram(inputs[1])
                    .Select(i => i.ToString()))
            );

            Assert.Equal("2,4,4,5,99,9801", string.Join(",",
                pc.RunIntCodeProgram(inputs[2])
                    .Select(i => i.ToString()))
            );

            Assert.Equal("30,1,1,4,2,5,6,0,99", string.Join(",",
                pc.RunIntCodeProgram(inputs[3])
                    .Select(i => i.ToString()))
            );

        }
    }
}
