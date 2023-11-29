namespace studentsMark
{
    public class DataContext
    {
        public  List <Teacher> teachers { get; set; }
        public  List<Companies> companies { get; set; }
        public  List<students> Student { get; set; }
        public DataContext()
        {
            teachers = new List<Teacher>
            {
               new Teacher("stefan","c#",30),new Teacher("rinder","algoritmim",27),new Teacher("prag","java",40),new Teacher("keila","c",15)
            };
            companies = new List<Companies>
         { new Companies("active","google",30,3),new Companies("active","Microsoft",27,2),new Companies("NoActive","IBM",20,10)
        };
            Student = new List<students> {
            new students("racheli", 100, 98, 100, 90, "0556788527"), new students("malki", 90, 88, 92, 87, "0556723013"), new students("esti", 95, 90, 91, 78, "0526765456")
        };
        }

      
    }
}
