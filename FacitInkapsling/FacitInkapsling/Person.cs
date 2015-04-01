using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacitInkapsling
{
    /// <summary>
    /// The person class, defines properties, variables and methods for a person
    /// </summary>
    class Person //Step 1 was to create this class
    {
        #region Step2
        private int _Age;
        private string _FName;
        private string _LName;
        private double _Height;
        private double _Weight;
        #endregion
        #region Step3
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public string FName 
        {
            get { return _FName; }
            set { _FName = value; }
        }
        public string LName 
        {
            get { return _LName; }
            set { _LName = value; }
        }
        public double Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
        public double Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }
        #endregion
        //For step 4 see program.cs
    }
}
