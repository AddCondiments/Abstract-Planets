using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* July 28th
 * Matthew Watada
 * 300832220
 * Starting late I know, but doable.
 * Version 0.7: Home stretch! Just need to instanciate some objects of type (GiantPlanet) and (TerrestrialPlanet) and I'm done!
 * Versions will update based on items added to the 
 * project, and not based on iterations of the same file.
 */

namespace Abstract_Planets
{
    class Program
    {

        /// <summary>
        /// There were a lot of unused properties.
        /// With the current assignment requirements,
        /// the fourth parameters for GiantPlanet objects and TerrestrialPlanet objects will not print...
        /// The lab last night was a bit more trouble that it was worth, only because I couldn't figure out how to use 
        /// the VS github extension properly ...again.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            // Let's make some P L A N E T S ! ! ! 
            GiantPlanet bigBigBoy = new GiantPlanet("Jupiter", 139822, 1.898 * (Math.Pow(10,27)), "Gas Giant? I don't even know...");
            TerrestrialPlanet leafyGreenBoy = new TerrestrialPlanet("Bob aka. New Earth", 12742, 5.972 * (Math.Pow(10,24)), false);
            Console.WriteLine("BigBigBoy -- \n{0}", bigBigBoy.ToString());
            Console.WriteLine("LeafyGreenBoy -- \n{0}", leafyGreenBoy.ToString());

            waitForAnyKey();
        }

        /// <summary>
        /// A method that will  wait for the user to hit a key, in order to continue.
        /// </summary>

        static void waitForAnyKey()
        {
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
