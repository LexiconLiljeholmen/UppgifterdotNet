using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacitPolymorfism
{
    class Program
    {
        /// <summary>
        /// The main class, will keep the program open and run some operations.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {
            //For step 1, see Animal.cs
            #region Step5
            List<Animal> animalList = new List<Animal>();
            #endregion
            #region Step6
            animalList.Add(new Dog { Name = "Fido", Age = 2, HasTail = true, Origin = "Sweden", IsMammal = true, TypeOfDog = "Wolfdog" });
            animalList.Add(new Worm { Name = "Ester", Age = 1, IsBandWorm = true, IsMammal = false, length = 13, Origin = "Kenya" });
            animalList.Add(new Horse { Name = "Spirit", Age = 2, breed = "Shetland", IsMammal = true, IsRaceHorse = true, Origin = "Iceland" });
            #endregion
            #region Step7
            foreach (Animal ani in animalList)
            {
                Console.WriteLine(Convert.ToString(ani.GetType()).Split('.').Last());
            }
            Console.ReadLine();
            #endregion
            #region Step8-10
            List<Dog> doges = new List<Dog>(); //Step 8
            //doges.Add(new Horse()); Step 9 <--- Doesn't work because Horse is not TypeOf Dog Step 10
            #endregion
            //For step 11 and 12, see Animal.cs
            #region Step 13-16
            //Step 13: Bird (List<Bird>)
            //Step 14: Animal (List<Animal>)
            //Step 15: Bird
            //Step 16: Animal
            #endregion
        }
    }
}
