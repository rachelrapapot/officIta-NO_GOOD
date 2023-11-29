namespace studentsMark
{
    public class students
    {
        public int Id { get; private set; }
        public static int id { private get; set; }
        public students(string Name, int Mark_c, int Mark_HTML, int Mark_Java, int Mark_Pyton, string f_number)
        {
            id++;
            Id = id;
            this.Name = Name;
            this.Mark_c = Mark_c;
            this.Mark_HTML = Mark_HTML;
            this.Mark_Java = Mark_Java;
            this.Mark_Pyton = Mark_Pyton;
            this.f_number = f_number;

        }
        public string Name { get; set; }
        public int Mark_c { get; set; }
        public int Mark_HTML { get; set; }
        public int Mark_Java { get; set; }
        public int Mark_Pyton { get; set; }
        public string f_number { get; set; }

    }
}