
using GuildClassLibrary;

namespace lab05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Guild guild = new Guild();
            guild.CharacterAdded += CharacterAdded;
            guild.AddHirelingToList(new Character("Maciek", 1, 1, 100, 100, 100, 0));
            guild.AddHirelingToList(new Character("Piotrek", 1, 1, 150, 150, 50, 0));
            guild.AddHirelingToList(new Character("Bartek", 1, 1, 50, 50, 150, 0));
            guild.AddHirelingToList(new Character("Rafałek", 1, 1, 200, 200, 10, 1));

            Monster Mosqito = new Monster("Komar", 5, 1);
            Monster Cat = new Monster("Kotek", 20, 50);
            Monster Lizard = new Monster("Jaszczurka", 100, 68);
            Monster Dragon = new Monster("Smok", 500, 300);

            guild.QuestAdded += x => Console.WriteLine("w wyprawie " + x.name + " jest potwór " + x.monster.name);
            guild.AddQuestsToList(new Quest("Bagnooo", "straszne bagno, błoto po kolana, i komary gryzą", "na bagnie", QuestDificult.treningowe, Mosqito, 10, 5));
            guild.AddQuestsToList(new Quest("Kotoprzygoda", "jest kot i pilnuje psa", "podwórko", QuestDificult.proste, Cat, 20, 0));
            guild.AddQuestsToList(new Quest("bleble", "jaszczurka pilnuje szkrzynki ze złotem, jeśli pokonasz jaszczurke to masz złoto esss", "jaksinia", QuestDificult.średnio, Lizard, 100, 5000));
            guild.AddQuestsToList(new Quest("DragonDungeon", "smok, ten sam który pilnował złota krasnali. Nie lubi hobbitów", "góra", QuestDificult.piekielnie_trudne, Dragon, 10000, 5000000));

            Console.WriteLine(guild.GetCharacterByName("Maciek").ToString());
            Console.WriteLine(guild.GetQuestByName("Bagnooo").ToString());

            guild.SendHirelingOnQuest(guild.GetCharacterByName("Maciek"), guild.GetQuestByName("Bagnooo"));
        }
        public static void CharacterAdded(Character character)
        {
            Console.WriteLine("imie dodanego bohatera to : " + character.name);
        }
    }
}