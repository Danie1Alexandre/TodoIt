using System;
using TodoIt.Model;
using TodoIt.Data;



namespace TodoIt
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Person neo = new Person(1999) {FirstName = "Neo", LastName = "The One"};
            
            //alternativ or second way of declaring neo
            Person neo2 = new Person(1992);
            neo2.FirstName = "Neo2";
            neo2.LastName = "The One2";
            Console.WriteLine(neo2.PersonID);
            Console.WriteLine(neo2.FirstName);
            Console.WriteLine(neo2.LastName + "\n");

            Todo todoObject = new Todo(2001, "Space odyssey");
            PersonSequencer runSequence = new PersonSequencer() {PersonId = 1998 };
            TodoSequencer runToDoSequence = new TodoSequencer() { ToDoId = 10 };

            //person
            Console.WriteLine(neo);
            Console.WriteLine(neo.PersonID);
            Console.WriteLine(neo.FirstName);
            Console.WriteLine(neo.LastName + "\n") ;
            
            //todo
            Console.WriteLine(todoObject.TodoId);
            Console.WriteLine(todoObject.Description+ "\n");
           
            //next id
            Console.WriteLine(runSequence.PersonId);
            runSequence.PersonId = PersonSequencer.NextPersonId();
            Console.WriteLine(runSequence.PersonId);
            runSequence.PersonId = PersonSequencer.NextPersonId();
            Console.WriteLine(runSequence.PersonId + "\n");
            
            //reset id
            runSequence.PersonId = PersonSequencer.Reset();
            Console.WriteLine(runSequence.PersonId);
            runSequence.PersonId = PersonSequencer.NextPersonId();
            Console.WriteLine(runSequence.PersonId);
            runSequence.PersonId = PersonSequencer.Reset();
            Console.WriteLine(runSequence.PersonId + "\n");

            //next Todoid
            Console.WriteLine(runToDoSequence.ToDoId);
            runToDoSequence.ToDoId = TodoSequencer.NextToDoId();
            Console.WriteLine(runToDoSequence.ToDoId);
            runToDoSequence.ToDoId = TodoSequencer.NextToDoId();
            Console.WriteLine(runToDoSequence.ToDoId + "\n");

            //Reset Todoid
            runToDoSequence.ToDoId = TodoSequencer.ResetToDO();
            Console.WriteLine(runToDoSequence.ToDoId);
            runToDoSequence.ToDoId = TodoSequencer.NextToDoId();
            Console.WriteLine(runToDoSequence.ToDoId);
            runToDoSequence.ToDoId = TodoSequencer.ResetToDO();
            Console.WriteLine(runToDoSequence.ToDoId + "\n");

            //Pepole
            /* First creat People class, then creat a array for people
             * then creat pepole to add int to the array. Last, add the pepole to the array.  (also copy new array to the arry in people class)*//*
            
            People theMatrix = new People();
            
            Console.WriteLine(theMatrix.ArrayWithPeople.Length);

            Person[] array = new Person[3];
            Person neo3 = new Person(1992) { FirstName = "Neo3", LastName = "The One3 its ready" };
            Person morpheus = new Person(1999) { FirstName = "morpheus", LastName = "Red Pill" };
            

            array[1] = neo3;
            array[2] = morpheus;

            theMatrix.ArrayWithPeople = array;
       

            Console.WriteLine(array[1].PersonID + array[1].FirstName + array[1].LastName);
            Console.WriteLine(theMatrix.ArrayWithPeople[1].FirstName);
            Console.WriteLine(theMatrix.ArrayWithPeople[2].PersonID + " " + theMatrix.ArrayWithPeople[2].FirstName + " " + theMatrix.ArrayWithPeople[2].LastName);
            Console.WriteLine(theMatrix.ArrayWithPeople.Length);
            Console.WriteLine(theMatrix.Size());
            Console.WriteLine(theMatrix.FindAll());

            //person find by id
            Console.WriteLine(theMatrix.FindById(1999).LastName);*/

            // add person
           /* People theMatrix = new People();

            Person mrAndessson = new Person(2002);
            mrAndessson = theMatrix.addNewPerson("mr", "andresson");
            Console.WriteLine(theMatrix.ArrayWithPeople[0].PersonID + " " + theMatrix.ArrayWithPeople[0].FirstName + " " + theMatrix.ArrayWithPeople[0].LastName);

            Person Trinity = new Person(2002);
            Trinity = theMatrix.addNewPerson("Trinity", "love");
            Console.WriteLine(theMatrix.ArrayWithPeople[1].PersonID + " " + theMatrix.ArrayWithPeople[1].FirstName + " " + theMatrix.ArrayWithPeople[1].LastName);

            Console.WriteLine(theMatrix.FindById(2).LastName);

            theMatrix.Clear();

            TodoItems toDoCreator = new TodoItems();




            toDoCreator.addNewTodo();
            toDoCreator.TodoArray[0].Description = "blue";
            toDoCreator.TodoArray[0].Done = false;

            toDoCreator.addNewTodo();
            toDoCreator.TodoArray[1].Description = "blue";
            toDoCreator.TodoArray[1].Done = true;

            toDoCreator.addNewTodo();
            toDoCreator.TodoArray[2].Description = "blue";
            toDoCreator.TodoArray[2].Done = false;

            toDoCreator.addNewTodo();
            toDoCreator.TodoArray[3].Description = "blue";
            toDoCreator.TodoArray[3].Done = true;

            toDoCreator.addNewTodo();
            toDoCreator.TodoArray[4].Description = "blue";
            toDoCreator.TodoArray[4].Done = false;


            Console.WriteLine(toDoCreator.TodoArray[0].Description);
            toDoCreator.TodoArray[0].Description = "red";
            Console.WriteLine(toDoCreator.TodoArray[0].Description);
            Console.WriteLine(toDoCreator.TodoArray[0].Done);

            Todo[] doneStatus = new Todo[0];

            doneStatus = toDoCreator.FindByDoneStatus(false);
           
            Console.WriteLine(doneStatus[0].Done);
            Console.WriteLine(doneStatus.Length);

            
            Console.WriteLine("\nloop");
            
            int x = 0;
            for (int i = 0; i < doneStatus.Length; i++)
            {
                Console.WriteLine(doneStatus[x].Done);
                x++; 
            }*/

            Console.WriteLine("Assignee");
            // assaignee
            //add person
            Person mrAndessson = new Person(2002);
            People theMatrix = new People();
            mrAndessson = theMatrix.addNewPerson("mr", "andresson");

            // add task
            TodoItems toDoCreator = new TodoItems();
            toDoCreator.addNewTodo();
            toDoCreator.TodoArray[0].Assignee = mrAndessson;
            
            
            //task to do created 1
            Todo driveToSchool = new Todo(0, "Drive");
            // task adde to array
            toDoCreator.TodoArray[0] = driveToSchool;
            // tassk i assigneed to a person
            driveToSchool.Assignee = mrAndessson;

            //task 2
            Todo fish = new Todo(1, "fish");
            toDoCreator.addNewTodo();
            toDoCreator.TodoArray[1] = fish;
            

            //task 
            Todo cookFood = new Todo(2, "cook");
            toDoCreator.addNewTodo();
            toDoCreator.TodoArray[2] = cookFood;
            

            Todo[] assigneeArray = new Todo[0];




            /*
            
            assigneeArray = toDoCreator.FindByAssignee (1);


            
            Console.WriteLine(assigneeArray.Length);
            Console.WriteLine(toDoCreator.TodoArray[0].Assignee.LastName);
            Console.WriteLine(toDoCreator.TodoArray[0].Assignee.PersonID);

            
            Console.WriteLine("\n loop test");
            Console.WriteLine(assigneeArray[0].Assignee.FirstName);
            int x = 0;
            for (int i = 0; i < assigneeArray.Length; i++)
            {
                Console.WriteLine(assigneeArray[x].Description);
                x++;
            }

            assigneeArray = toDoCreator.FindByAssignee(mrAndessson);
            Console.WriteLine(assigneeArray[0].Assignee.LastName);

            x = 0;
            for (int i = 0; i < assigneeArray.Length; i++)
            {
                Console.WriteLine(assigneeArray[x].Description);
                x++;
            }
            */
            assigneeArray = toDoCreator.FindUnassignedTodoItems();
            Console.WriteLine(assigneeArray[0].Description);
            Console.WriteLine(assigneeArray[1].Description);
            Console.WriteLine(assigneeArray.Length);
            int x = 0;
            for (int i = 0; i < assigneeArray.Length; i++)
            {
                Console.WriteLine(assigneeArray[x].Description);
                x++;
            }
            TodoSequencer Number = new TodoSequencer();
            Console.WriteLine("sn" + Number.ToDoId);


            assigneeArray = toDoCreator.removeObjectFromArray(2);
            x = 0;
            Console.WriteLine("clear made: " + assigneeArray.Length);
            for (int i = 0; i < assigneeArray.Length; i++)
            {
                Console.WriteLine(assigneeArray[x].Description);
                x++;
            }
            Console.WriteLine("sn" + Number.ToDoId);

            Todo fish2 = new Todo(1, "lax");
            toDoCreator.addNewTodo();
            toDoCreator.addNewTodo();

            toDoCreator.TodoArray[2] = fish2;

            Console.WriteLine("sn" + Number.ToDoId);



            Console.ReadKey();

        }
    }
        
}
