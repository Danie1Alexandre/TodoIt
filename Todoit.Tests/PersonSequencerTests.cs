using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Data;
using Xunit;

namespace Todoit.Tests
{
    public class PersonSequencerTests
    {
        [Fact]
        public void NextPersonSequencerTests()
        {
            PersonSequencer runPersonSequencer = new PersonSequencer();
            runPersonSequencer.PersonId = 0;
            int expectedOutcome = 1;

            runPersonSequencer.PersonId = PersonSequencer.NextPersonId();

            Assert.Equal(expectedOutcome, runPersonSequencer.PersonId);
            Assert.NotEqual(2, runPersonSequencer.PersonId);
        }

        [Fact]
        public void ResetPersonSequencerTests()
        {
            int tesNumber = 10;
            int expectedOutcome = 0;
            tesNumber = PersonSequencer.Reset();
            Assert.Equal(expectedOutcome, tesNumber);
            Assert.NotEqual(10, tesNumber);
        }

    }
}
