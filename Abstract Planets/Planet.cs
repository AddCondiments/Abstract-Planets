using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* July 28th
 * Matthew Watada
 * 300832220
 * Starting late I know, but doable.
 * Version 0.1: starting with the abstract class "Planet". 
 * Versions will update based on items added to the 
 * project, and not based on iterations of the same file.
 */

namespace Abstract_Planets
{
    /// <summary>
    /// This is the Planet class!
    /// </summary>
    public abstract class Planet
    {
        // Private Instance Variables

        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // Public Properties

        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        public double Mass
        {
            get
            {
                return this._mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double ROtationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        /// <summary>
        /// This constructer takes 3 parameters, and instanciates them to the private instance variables (_name, _diameter, and _mass).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>

        // Constructors

        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        // Private Methods (None that I can see)



        // Public Methods

        /// <summary>
        /// The ToString() method fromats the output in the console for objects of type 'Planet', or those that inherit from it.
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return string.Format("Name: {0}\nDiameter: {1} km\nMass: {2}kg\n", Name, Diameter, Mass);
        }
    }
}
