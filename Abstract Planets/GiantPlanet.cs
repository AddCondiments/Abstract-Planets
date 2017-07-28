using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* July 28th
 * Matthew Watada
 * 300832220
 * Starting late I know, but doable.
 * Version 0.2: Now with GiantPlanet subclass (inherits from "Planet" class).
 * The class now implements IHasMoons and IHasRings interfaces.
 * Versions will update based on items added to the 
 * project, and not based on iterations of the same file.
 */

namespace Abstract_Planets
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // Private Instance Variables
        private string _type;

        // Public Properties

        // Constructors

        /// <summary>
        /// This is where you troubleshoot accessibility from the "Planet" class, and make it public.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>

        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }

        // Private Methods

        // Public Methods

        /// <summary>
        /// 2 different methods that return boolean values depending on whether or not a 'Planet' object has moons, or has rings.
        /// </summary>
        /// <returns></returns>

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("No Moons!");
                return false;
            }
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("No Rings!");
                return false;
            }
        }

    }
}
