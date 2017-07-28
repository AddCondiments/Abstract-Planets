using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* July 28th
 * Matthew Watada
 * 300832220
 * Starting late I know, but doable.
 * Version 0.5: The "TerrestrialPlanet" class is straight forward. 
 * A subclass for habitable planet objects.
 * Versions will update based on items added to the 
 * project, and not based on iterations of the same file.
 */

namespace Abstract_Planets
{
    public class TerrestrialPlanet : Planet, IHasMoons
    {
        // Private Instance Variables

        private bool _oxygen;

        // Public Properties

        // Constructors
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // Private Methods

        // Public Methods

        public bool HasMoons()
        {
            return (MoonCount > 0);
        }
        public bool Habitable()
        {
            return (this._oxygen);
        }
    }
}
