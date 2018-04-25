namespace human
{
    class Monster : Human
    {
        public string name;
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Monster(string name) : base(name)
        {
            // TODO: make a monster class
        }


    }
}