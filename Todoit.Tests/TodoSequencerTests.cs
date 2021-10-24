using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TodoIt.Data;

namespace Todoit.Tests
{

    public class TodoSequencerTests
    {
        [Fact]
        public void NextToDoIdSequencerTests()
        {
            TodoSequencer runTodoSequencer = new TodoSequencer();
            runTodoSequencer.ToDoId = 0;
            int expectedOutcome = 1;

            runTodoSequencer.ToDoId = TodoSequencer.NextToDoId();

            Assert.Equal(expectedOutcome, runTodoSequencer.ToDoId);
            Assert.NotEqual(2, runTodoSequencer.ToDoId);
        }

        [Fact]
        public void resetDoIdSequencerTests()
        {
            int tesNumber = 10;
            int expectedOutcome = 0;
            tesNumber = TodoSequencer.ResetToDO();
            Assert.Equal(expectedOutcome, tesNumber);
            Assert.NotEqual(2, tesNumber);
        }
    }  
}
