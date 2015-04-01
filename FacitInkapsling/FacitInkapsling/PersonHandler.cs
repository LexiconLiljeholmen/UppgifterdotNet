using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacitInkapsling
{
    /// <summary>
    /// The PersonHandler class, handles logic linked to the Person class.
    /// Works as an abstractionlayer
    /// </summary>
    class PersonHandler//Step 5 was to create this class
    {
        #region Step6
        /// <summary>
        /// Sets the age of a person
        /// </summary>
        /// <param name="pers">The person object</param>
        /// <param name="age">Age to set</param>
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        #endregion
        #region Step7
        /// <summary>
        /// The Create person method, creates a person with input properties
        /// </summary>
        /// <param name="age">Age for the new person</param>
        /// <param name="fname">FName for the new person</param>
        /// <param name="lname">LName for the new person</param>
        /// <param name="height">Height for the new person</param>
        /// <param name="weight">Weight for the new person</param>
        /// <returns></returns>
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            return new Person { Age = age, FName = fname, LName = lname, Height = height, Weight = weight };
        }
        #endregion
        #region Step8
        //The following mehtods are examples
        /// <summary>
        /// CreateAnon method creates a person with the name "John Doe"
        /// </summary>
        /// <param name="age">Age of the anon person</param>
        /// <param name="height">Height of the anon person</param>
        /// <param name="weight">Weight of the anon person</param>
        /// <returns></returns>
        public Person CreateAnon(int age, double height, double weight)
        {
            return new Person { Age = age, Height = height, Weight = weight, FName = "John", LName = "Doe" };
        }
        /// <summary>
        /// The Married method takes two persons and a last name and sets the last name of
        /// the two persons to the specified last name
        /// </summary>
        /// <param name="person1">First person</param>
        /// <param name="person2">Second person</param>
        /// <param name="LastName">New Last Name</param>
        public void Married(Person person1, Person person2, string LastName)
        {
            person1.LName = LastName;
            person2.LName = LastName;
        }
        /// <summary>
        /// The NameChange method changes the FName of a person
        /// </summary>
        /// <param name="personToChange">Person whos name is to change</param>
        /// <param name="NewFName">New FName for the person</param>
        public void NameChange(Person personToChange, string NewFName)
        {
            personToChange.FName = NewFName;
        }
        /// <summary>
        /// The NameChange method changes the FName and LName of a person
        /// </summary>
        /// <param name="personToChange">Person whos name is to change</param>
        /// <param name="NewFName">New FName for the person</param>
        /// <param name="NewLName">New LName for the person</param>
        public void NameChange(Person personToChange, string NewFName, string NewLName)
        {
            personToChange.FName = NewFName;
            personToChange.LName = NewLName;
        }
        #endregion
    }
}
