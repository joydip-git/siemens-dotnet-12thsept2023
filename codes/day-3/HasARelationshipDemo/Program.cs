using System;
using System.Collections.Generic;

namespace HasARelationshipDemo
{
    internal class Program
    {
        static void Main()
        {
            Building firstBuilding = new Building();
            firstBuilding.Id = 1;
            firstBuilding.Name = "Siemens Health";

            //Building secondBuilding = new Building();
            //secondBuilding.Name = "Siemens S&T";

            Room firstRoom = new Room();
            firstRoom.Id = 1;
            firstRoom.Name = "Conference Room - M04";
            firstRoom.Building = firstBuilding;
            //firstRoom.BuildingId = 2;

            Room secondRoom = new Room();
            secondRoom.Id = 2;
            secondRoom.Name = "Training Room - L5";
            secondRoom.Building = firstBuilding;

            HashSet<Room> roomSet = new HashSet<Room>();
            roomSet.Add(firstRoom);
            roomSet.Add(secondRoom);

            firstBuilding.Rooms = roomSet;

            Console.WriteLine(firstRoom.Building.Name);

            foreach (Room item in firstBuilding.Rooms)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
