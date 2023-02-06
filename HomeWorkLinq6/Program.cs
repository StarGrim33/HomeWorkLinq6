namespace HomeWorkLinq6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Headquarters headquarters = new();
            headquarters.ShowSoldiers();
        }
    }

    class Headquarters
    {
        private List<Soldier> _soldiers = new();

        public Headquarters()
        {
            AddSoldiers();
        }

        public void ShowSoldiers()
        {
            var soldiers = _soldiers.Select(soldier => new { soldier.Name, soldier.Rank }).ToList();

            foreach(var soldier in soldiers)
            {
                Console.WriteLine($"{soldier.Name}, звание: {soldier.Rank}");
            }
        }

        private void AddSoldiers()
        {
            _soldiers = new()
            {
               new Soldier("Андрей", "Винтовка", "Рядовой", 5),
               new Soldier("Вячеслав", "Автомат", "Младший Сержант", 14),
               new Soldier("Сергей", "Табельный пистолет", "Прапорщик", 22),
               new Soldier("Владимир", "Снайперская винтовка", "Лейтенант", 46),
               new Soldier("Дмитрий", "Миномет", "Сержат", 16),
            };
        }
    }

    class Soldier
    {
        public Soldier(string name, string weapon, string rank, int serviceTime)
        {
            Name = name;
            Weapon = weapon;
            Rank = rank;
            ServiceTime = serviceTime;
        }

        public string Name { get; private set; }

        public string Weapon { get; private set; }

        public string Rank { get; private set; }

        public int ServiceTime { get; private set; }
    }
}