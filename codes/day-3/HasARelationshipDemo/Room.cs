namespace HasARelationshipDemo
{
    public class Room
    {
        private string name;
        private int id;
        private int buildingId;
        //navigation member
        private Building building;

        public Room() { }

        //optional argument with default value
        //note: all optional arguments should be declared at the end of the argument list
        public Room(int id, string name, Building building, int buildingId = 0)
        {
            this.id = id;
            this.name = name;
            this.building = building;
            this.buildingId = buildingId;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        //navigation property
        public Building Building
        {
            get => building;
            set => building = value;
        }
        public int Id { get => id; set => id = value; }
        public int BuildingId { get => buildingId; set => buildingId = value; }

        public override int GetHashCode()
        {
            return this.id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this.id.Equals(((Room)obj).id);
        }
    }
}
