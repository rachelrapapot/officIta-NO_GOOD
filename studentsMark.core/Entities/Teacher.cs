namespace studentsMark
{
    public class Teacher
    {
        public int Id { get; private set; }
        public static int id { private get; set; }
        public string Name { get; set; }
        public string Proffesional { get; set;}
        public int hours { get; set; }
        public Teacher(string Name,string Proffesional,int hour)
        {
            id++;
            Id = id;
            this.Name = Name;
            this.Proffesional= Proffesional;
            this.hours = hour;
        }
        
    }
}
