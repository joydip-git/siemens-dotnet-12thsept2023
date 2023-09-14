using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasARelationshipDemo
{
    public class Building
    {
        private string name;
        private int id;
        //navigation member
        private HashSet<Room> rooms;

        public Building() { }
        public Building(int id, string name, HashSet<Room> rooms)
        {
            this.id = id;
            this.name = name;
            this.rooms = rooms;
        }

        public string Name { get => name; set => name = value; }
        public HashSet<Room> Rooms { get => rooms; set => rooms = value; }
        public int Id { get => id; set => id = value; }
    }
}
