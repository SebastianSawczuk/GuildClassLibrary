namespace GuildClassLibrary
{
    public class Guild
    {
        private List<Character> characters = new List<Character>();
        private List<Quest> quests = new List<Quest>();
        public delegate void characterDelegate(Character character);
        public delegate void questDelegate(Quest quest);
        public delegate void bothDelegate(Character character, Quest quest);

        public event characterDelegate CharacterAdded;
        public event questDelegate QuestAdded;
        public event bothDelegate OnQuestAdded;
        public event bothDelegate OnQuestAdding;

        public void AddHirelingToList(Character character)
        {
            characters.Add(character);
            CharacterAdded?.Invoke(character);
        }


        public void AddQuestsToList(Quest quest)
        {
            quests.Add(quest);
            QuestAdded?.Invoke(quest);
        }

        public void SendHirelingOnQuest(Character character, Quest quest)
        {
            OnQuestAdding?.Invoke(character, quest);
            if (character.numOfActualHelthPoints > quest.monster.damage)
            {
                character.experience += quest.experiance;
                character.gold += quest.gold;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(character.name + " ukończył wyoprawę i uzyskał " + quest.experiance + " punktów doświadczenia, oraz " + quest.gold + " sztabek złota !");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(character.name + " został pokonany przez " + quest.monster.name);
                Console.ForegroundColor = ConsoleColor.White;
            }
            OnQuestAdded?.Invoke(character, quest);
        }

        public void ProcessQuest(questDelegate proc)
        {
            foreach (Quest quest in quests)
            {
                proc(quest);
            }
        }

        public void ProcessCharacter(characterDelegate proc)
        {
            foreach (Character character in characters)
            {
                proc(character);
            }
        }

        public Quest GetQuestByName(string name)
        {
            return quests.Find(x => x.name == name);
        }

        public Character GetCharacterByName(string name)
        {
            return characters.Find(x => x.name == name);
        }

        public List<Quest> GetQuestByLocationAndDificult(string location, string difficult)
        {
            return quests.FindAll(x => x.location == location && x.questDifficult.ToString() == difficult);
        }

        public List<Character> GetCharactersByLevel(int level)
        {
            return characters.FindAll(x => x.level > level);
        }
    }
}
