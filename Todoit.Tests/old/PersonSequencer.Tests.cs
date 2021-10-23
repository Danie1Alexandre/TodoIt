/*using System;
using Xunit;
using TodoIt.Data;

namespace Todoit.Tests
{
    public class PersonSequencerTests
    {
        // Test for PersonSequencer to see if number is increasing
        [Fact]
        public void SequencerTests()
        {
            int testNumber = 4;
            int expectedNumber = 5;
            testNumber += PersonSequencer.NextPersonId();
            Assert.Equal(testNumber, expectedNumber);

            expectedNumber = 7;
            testNumber += PersonSequencer.NextPersonId();
            Assert.Equal(testNumber, expectedNumber);


        }

      
        // Test for Sequencer rest to see if number rests to zero
        [Fact]
        public void SequencerResetTests()
        {
            int testNumber = 10;
            int expectedNumber = 0;
            testNumber = PersonSequencer.Reset();
            
            Assert.Equal(testNumber, expectedNumber);
        }
        
    }
    
}
    */