namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Vendor VendorWorkingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public bool HasAQuest { get { return QuestAvailableHere != null; } }
        public bool DoesNotHaveAnItemRequiredToEnter { get { return ItemRequiredToEnter == null; } }

        public Location(int id, string name, string description, 
            Item itemRequiredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
        }

        public Monster NewInstanceOfMonsterLivingHere()
        {
            return MonsterLivingHere == null ? null : MonsterLivingHere.NewInstanceOfMonster();
        }
    }
}
