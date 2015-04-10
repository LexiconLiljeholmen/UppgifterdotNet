using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacitPolymorfism
{
    /// <summary>
    /// Super class for all Animals
    /// </summary>
    public class Animal //Step1 was to create this class
    {
        #region Step2
        public string Name { get; set; }
        public string Origin { get; set;}
        public int Age { get; set; }
        public bool IsMammal { get; set; }
        #endregion

    }
    #region Step3
    public class Horse : Animal
    {
        #region Step4Horse
        public string breed {get; set;}
        public bool IsRaceHorse {get;set; }
        #endregion
    }
    public class Dog : Animal
    {
        #region Step4Dog
        public bool HasTail {get;set;}
        public string TypeOfDog {get;set;}
#endregion
    }
    public class Worm : Animal
    {
        #region Step4Worm
        public bool IsBandWorm {get;set;}
        public int length {get;set;}
#endregion

    }
    public class Hedgehog : Animal
    {
        #region Step4Hedgehog
        public int NumOfSpikes{get;set;}
        public bool IsResting {get; set;}
        #endregion
    }
    public class Bird : Animal
    {
        #region Step4Bird
        public bool IsMovingBird {get;set;}
        public int BeakSize {get;set;}
        #endregion
    }
    #endregion
#region Step11
    /// <summary>
    /// The flamingo class, holds properties specific for flamingos. Subclass of bird
    /// </summary>
    public class Flamingo : Bird
    {
        #region Step12 Falmingo
        public bool standing { get; set; }
        public int numOfChildren { get; set; }
        #endregion
    }

    /// <summary>
    /// The Pelican class, holds properties specific for pelican. Subclass of bird
    /// </summary>
    public class Pelican : Bird
    {
        #region Step12 Pelican
        public int sizeOfMouth { get; set; }
        public string name { get; set; }
        #endregion
    }

    /// <summary>
    /// The pelican class, holds properties specific for pelican. Subclass of bird
    /// </summary>
    public class Swan : Bird
    {
        #region Step12 Falmingo
        public bool isWhite { get; set; }
        public int neckLength { get; set; }
        #endregion
    }
#endregion
}
