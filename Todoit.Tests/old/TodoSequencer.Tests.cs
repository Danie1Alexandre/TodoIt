/*using System;
using Xunit;
using TodoIt.Data;

namespace Todoit.Tests
{
    
    public class TodoSequencerTests
    {
        public class PersonSequencerTests
        {
            // Test for TodoSequencer to see if number is increasing
            [Fact]
            public void TodoSequencerTests()
            {
                int testNumber = 5;
                int expectedNumber = 6;
                testNumber += TodoSequencer.NextToDoSequnceNumber();

                Assert.Equal(testNumber, expectedNumber);
            }

            // Test for TodoSequencer rest to see if number rests to zero
            [Fact]
            public void TdoSequencerResetTests()
            {
                int testNumber = 10;
                int expectedNumber = 0;
                testNumber = TodoSequencer.ResetToDoSequnceNumber();
            
                Assert.Equal(testNumber, expectedNumber);
            }
        }
    }
    
}
*/