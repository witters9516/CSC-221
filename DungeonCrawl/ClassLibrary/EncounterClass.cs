using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EncounterClass
    {
        //The RandomEncounter Method accepts a string as an argument.
        //@param roomName - The name of the current room.
        //@return returnEnemy - the enemy chosen for the encounter.
        public BaseBattlerClass RandomEncounter(string roomName)
        {
            //Variables
            BaseBattlerClass returnEnemy;   //Returned enemy after the function has run
            Random rand = new Random();     //Random Class instance
            int rand1;                      //Holds random number 1 - Encounter or no?
            int rand2;                      //Holds random number 2 - What enemy has been chosen?
            int roomNumber = 0;             //Current Room's number - needed to select that rooms enemies.

            //Set Room's index number.
            if (roomName == "City Outskirts")
                roomNumber = 1;
            else if (roomName == "Quickstop Station")
                roomNumber = 2;
            else if (roomName == "Walmart")
                roomNumber = 3;
            else if (roomName == "Safe Zone")
                roomNumber = 4;
            else if (roomName == "Marathon")
                roomNumber = 5;

            //Set List to the current rooms enemies.
            List<BaseBattlerClass> currentEnemyList = GetMonsterList(roomNumber);

            //Pick a number between 1 and 100.
            rand1 = rand.Next(0, 101);  //Random number 1 Range(1-100)

            if (rand1 <= 85)
            {
                //Encounter
                rand2 = rand.Next(0, currentEnemyList.Count);   //Pick an enemy in the currentEnemyList
                returnEnemy = currentEnemyList[rand2];  //Set returnEnemy to the rand2's index value in currentEnemyList. 
                return returnEnemy;
            }
            else
            {
                //No Encounter
                return null; //Return the empty object
            }
        }

        //The GetMontsterList takes an int as an argument.
        //@param roomNum - room index number
        //@return tempList - list of enemies that can appear in that particular Room.
        private List<BaseBattlerClass> GetMonsterList(int roomNum)
        {
            //TemporaryList that is used to hold a current rooms enemies.
            List<BaseBattlerClass> tempList = new List<BaseBattlerClass>();

            if (roomNum == 1)       //City Outskirts
            {
                tempList.Add(new AnimalClass());
                tempList.Add(new EvilHumanClass());
            }
            else if (roomNum == 2)  //Quickstop Station
            {
                tempList.Add(new AnimalClass());
                tempList.Add(new EvilHumanClass());
                tempList.Add(new WalkingZombieClass());
            }
            else if (roomNum == 3)  //Walmart
            {
                tempList.Add(new EvilHumanClass());
                tempList.Add(new WalkingZombieClass());
            }
            else if (roomNum == 4)  //Safe Zone
            {
                tempList.Add(new EvilHumanClass());
            }
            else if (roomNum == 5)  //Marathon
            {
                tempList.Add(new WalkingZombieClass());
                tempList.Add(new CrawlingZombieClass());
            }
            return tempList;
        }
    }
}
