namespace studentsMark
{
    public class Companies
    {
        public int Id { get; private set; }
        public static int id { private get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public int NumberOfWorkingHours { get; set; }
        public int AmountOfUltraOrthodox { get; set; }
        public Companies(string status, string name, int numberOfWorkingHours, int amountOfUltraOrthodox)
        {
            id++;
            Id = id;
            Status = status;
            Name = name;
            NumberOfWorkingHours = numberOfWorkingHours;
            AmountOfUltraOrthodox = amountOfUltraOrthodox;
        }
    }
}
