using System;
using System.Collections.Generic;

namespace chapter1_4
{
    class Program
    {
        static void Main(string[] args)
        {




//            Add() Jupiter and Saturn at the end of the list.
//Create another List that contains that last two planet of our solar system.
//Combine the two lists by using AddRange().
//Use Insert() to add Earth, and Venus in the correct order.
//Use Add() again to add Pluto to the end of the list.
//Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
//Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.










            ///////////////////////////////////////////////////
            ////////////Types of Variables in C#///////////////
            ///////////////////////////////////////////////////

            //this is how you definie or instantiate a variable(s)
            //hint: you have to define the variable above the code that uses that variable
            //hint: always put a ; after defining a variable or writting an array, list, if-statement, or for-loop, and after every Console.WriteLine put a semi-colon

            //defining(instantiate) a variable of type int
            int gradeOnTest1 = 80;
            int gradeOnTest2 = 100;
            //you can add variables together, even string but that is called concatination, and i will show that further down
            //below should print the average of the 2 test grades
            Console.WriteLine((gradeOnTest1 + gradeOnTest2) / 2 + " is " + "the"+" " +"average test score");

            //string(words or letters and always uses " " when defining a string variable)
            string studentFirstName = "Russell";
            string studentLastName = "Miller";
            //this is how you add two strings together
            Console.WriteLine(studentFirstName + studentFirstName);// if you check the output it is -- RussellMiller with no space
            Console.WriteLine(studentFirstName + " " + studentLastName);//this is why we learned $"{string interpolation}" see below
            Console.WriteLine($"The instructors name is {studentFirstName} {studentLastName}");

            //double is like int but you can have 2 decimal spots like below
            double GPA = 3.55;

            //char is just a single letter(character), can be upper or lower case
            char courseFinalGrade = 'A';

            Console.WriteLine(courseFinalGrade);



            /////////////////////////////////////////////
            ////////////Arrays in C#/////////////////////
            ////////////////////////////////////////////

            //you can also define(instantiate) a list or array, think of an array or <List> as a regular "numbered list" except its sideways and seperated by commas, and the first thing on the list is at spot 0 instead of 1 and we call this the index, the second item in every array is at index 1, the third item is at index 2, and so on...


            //array, you have to tell it what the items in the array are made up of: numners(int), letters(char), words(string), etc...


            //array of whole numbers
            float[] allQuizGrades = new float[8] { 99, 100, 84, 77, 7, 91, 13, 86 };

            //array of numners that have 2 decimal places
            double[] gpaBySemester = new double[4] { 4.00000, 3.5923423, 3.55, 3.84 };

            //array of strings(words)
            string[] studentNames = new string[4] { "Bobby", "Sarah", "Jessica", "John" };



            //////////////////////////////////////////////
            ////////////If Statements in C#///////////////
            //////////////////////////////////////////////


            //this is a simple if-else statemnt checking to see if the test grade is 90 or above
            if (gradeOnTest1 == 90)
            {
                Console.WriteLine($"you scored {gradeOnTest1} on the test which is an A");

            }
            else { Console.WriteLine("you didn't score an 90 exactly"); }



            //Another if statement but with the == to see if the two variables are the same

            if (studentFirstName == "Russ")
            {
                Console.WriteLine($"you have the best instructor and his name is {studentFirstName} and he is super humble");
            }


            //////////////////////////////////////////////////////
            ////////////For and Foreach Loops in C#///////////////
            /////////////////////////////////////////////////////

            //for loops are for looping over a list or array, or checking each item on the list top preform an operation or check with if statement, etc. You can put whatever logic you like between the two {    }as you see below in the first example            

            //this is a simple for loop that prints the index number to the console, its not printing any of the items on the list, just the index, or numbers of the list



            // it basically says to the computer, 
            // -start at spot 0 with ->(int k = 0)
            // -tells the computer to print the index its currently on --> Console.WriteLine(k)
            // -tell it how long the list is, here its 999 spots (k<=999), how many times to loop over the array
            // -says to count every single spot (k++) means k=k+1,
            for (int k = 0; k <= 999; k++)
            {
                Console.WriteLine(k);
            }
            // so the first loop k = 0, so k=0+1 simplifies to k=1
            // second loop k =1, so k=1+1 which simplifies to k=2
            //it continues looping until it hits the end of the list or until it returns a false(more on that later)

            //dont worry too much about for-loops, but understand what they are essentially doing, because we will use built-in functions that use for loops "behind the scenes" but simplify the process and amount of code to write. For-loop  principles apply to many useful built-in functions(you will use some in chapter 4 and throughout the rest of the course)



            /////////////////////////////////////////////////
            ////////////Lists and Foreach Loops in C#///////
            //////////////////////////////////////////////

            //Very similar to array's and for-loops, but these are easier and have more functionality, we will no longer use arrays after this chapter
            //this is how you instantiate a List, notice you have to still tell it what the list items are made up of, here its words(strings)
            List<string> students = new List<string>()
             {
                "Megan", "Damon", "Chase", "Tekisha",
                "Castle", "Mark", "Keith", "Adam",
                "Patrick", "Hannah", "Mike"
            };


            ///// 1) hard way to iterate through an array
            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);
            Console.WriteLine(students[3]);
            Console.WriteLine(students[4]);
            Console.WriteLine(students[5]);
            Console.WriteLine(students[6]);
            Console.WriteLine(students[7]);
            Console.WriteLine(students[8]);
            Console.WriteLine(students[9]);
            Console.WriteLine(students[10]);

            ////// 2) easier way to iterate through an array is with a foreach, which is like for-loop but much easier and it detects the length of the list or array automatically, there are many built in function within C# .NET Core that are very useful.
            foreach (string taco in students)
            {
                Console.WriteLine(taco);
            }

            ///// 3) easiest way to iterate over items in a list, this is the easiest of the 3
            students.ForEach(x => Console.WriteLine(x));

            //how to count how many items are in a list, you might get squiggly red line-> press lightbulb and chose first option, using linq..
            Console.WriteLine(students.Count);
            //you can add a number and a variable name together, you can divide 1/2 , remainder(modulus ) % , addition + and subtraction - , and many more with custom built-in functions and lib's you can download 
            Console.WriteLine(students.Count+1);









        }
    }
}
