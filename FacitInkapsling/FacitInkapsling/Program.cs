using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacitInkapsling
{
    /// <summary>
    /// The program class, will keep the application up and running
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main thread for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //For step 1-3 please see Person.cs
            #region Step4
            Person person = new Person();
            //int x = person._Age; <--- Does not work
            int x = person.Age; //<---- Works, Age is the public property while _Age is the private variable
            #endregion
            //For step 5 please see personhandler.cs
            #region Step8
            //Remove the content of step4 before going past this point
            PersonHandler pershand = new PersonHandler();
            Person testperson = pershand.CreatePerson(22, "Johanna", "Krohn", 1.55, 98.7);
            Person testperson2 = pershand.CreatePerson(45, "Gunnar", "Wängedahl", 2.10, 100);
            Console.WriteLine(testperson.FName + " " + testperson.LName + " is " + testperson.Age + " years old");
            Console.WriteLine(testperson2.FName + " " + testperson2.LName + " is " + testperson2.Age + " years old");
            pershand.Married(testperson, testperson2, "Now Married");
            Console.WriteLine(testperson.FName + " " + testperson.LName + " is " + testperson.Age + " years old");
            Console.WriteLine(testperson2.FName + " " + testperson2.LName + " is " + testperson2.Age + " years old");
            Console.ReadLine();
            #endregion
        }
    }
}
