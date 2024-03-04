namespace GuildClassLibrary
{
    public class Quest
    {

        public Quest()
        {
        }

        public string name { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public QuestDificult questDifficult { get; set; }
        public Monster monster { get; set; }
        public int experiance { get; set; }
        public int gold { get; set; }

        public Quest(string name, string description, string location, QuestDificult questDifficult, Monster monster, int experiance, int gold)
        {
            this.name = name;
            this.description = description;
            this.location = location;
            this.questDifficult = questDifficult;
            this.monster = monster;
            this.experiance = experiance;
            this.gold = gold;
        }

        public override string ToString()
        {
            return $"Nazwa wyprawy: {name}, Opis: {description}, Lokalizacja: {location}, Poziom trufności: {questDifficult}, Potwór: {monster.ToString()}, Doświadczenie do zdobycia: {experiance}, Złoto do zdobycia: {gold}";
        }
    }
}
