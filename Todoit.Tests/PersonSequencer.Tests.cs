using System;
using Xunit;
using TodoIt.Data;

namespace Todoit.Tests
{
    public class PersonSequencerTests
    {
        [Fact]
        public void SequencTests()
        {
            for (int i = 1; i < 7; i++)
            {
                int nextIdNumber = PersonSequencer.NextPersonId();

                Assert.Equal(i, nextIdNumber);
            }
        }
        //reset test, curentNumber starts with 5 but changes 0 with PersonSequencer.Reset to see if rest works. 
        [Fact]
        public void ResetTests()
        {
            int idReseted = 0;
            int curentNumber = 5, expected = 5;
            Assert.Equal(curentNumber,expected);
            curentNumber = PersonSequencer.Reset();
            Assert.Equal(idReseted, curentNumber);
        }
    }
}
