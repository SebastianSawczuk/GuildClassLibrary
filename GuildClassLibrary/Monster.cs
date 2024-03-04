namespace GuildClassLibrary
{
    public class Monster
    {
        public string name { get; set; }
        public int numOfHelthPoints { get; set; }
        public int damage { get; set; }

        public Monster() { }

        public Monster(string name, int numOfHelthPoints, int damage)
        {
            this.name = name;
            this.numOfHelthPoints = numOfHelthPoints;
            this.damage = damage;
        }

        public override string ToString()
        {
            return $"Imie: {name}, Liczba punktów życia: {numOfHelthPoints}, Zadawane obrażenia: {damage}";
        }
    }
}
