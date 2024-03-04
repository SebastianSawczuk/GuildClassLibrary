namespace GuildClassLibrary
{
    public class Character
    {

        public Character()
        {
        }

        public string name { get; set; }
        public int level { get; set; }
        public int experience { get; set; }
        public int numOfMaxHelthPoints { get; set; }
        public int numOfActualHelthPoints { get; set; }
        public int demage { get; set; }
        public int gold { get; set; }

        public Character(string name, int level, int experience, int numOfMaxHelthPoints, int numOfActualHelthPoints, int demage, int gold)
        {
            this.name = name;
            this.level = level;
            this.experience = experience;
            this.numOfMaxHelthPoints = numOfMaxHelthPoints;
            this.numOfActualHelthPoints = numOfActualHelthPoints;
            this.demage = demage;
            this.gold = gold;
        }

        public override string ToString()
        {
            return $"Imie: {name}, Level: {level}, Doświadczenie: {experience}, Maksymalna liczba punktów życia: {numOfMaxHelthPoints}, Liczba aktualnych punktów życia: {numOfActualHelthPoints}, Zadawane obrażenia: {demage}, Złoto: {gold}";
        }
    }
}
