/**
 * This class is for displaying story text to the screen when a function is called.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StoryTextClass
    {
        public string OpeningScene()
        {
            string output = "You arrive at the outskirts of the city. There are humans and animals roaming about. The city walls are keeping everyone out." +
                " You find a part of the wall where the foundation is weak. Try searching for something to break through the walls.";

            return output;
        }

        #region Finding Items
        public string NothingOfValue()
        {
            return " You did not find anything of value. ";
        }

        public string FoundHammer()
        {
            return " You found a Hammer. This can be used to break through the walls of the city.";
        }

        public string FoundFlashlight()
        {
            return " You found a Flashlight. This can be used light your way through walmart to look for supplies.";
        }

        public string FoundKeyToSafeZone()
        {
            return " You found a Key to the Safe Zone. This can be used unlock the door to the Safe Zone.";
        }

        public string FoundHiddenPathToMarathon()
        {
            return " You found the Hidden Path to the Marathon. This can be used to get to the Marathon with little to no zombie activity.";
        }
        #endregion
    }
}
