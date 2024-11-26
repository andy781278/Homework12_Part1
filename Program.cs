namespace Homework12_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person("Joe",20,1.8));
            list.Add(new Person("Joey", 9, 1.8));
            list.Add(new Person("Joseph", 6, 1.2));
            list.Add(new Person("John", 24, 1.6));
            list.Add(new Person("Joenatan", 20, 1.9));
            list.Add(new Person("Jon", 12, 1.7));
            list.Add(new Person("Jonatan", 20, 1.6));
            list.Add(new Person("Johnathan", 20, 1.7));
            list.Add(new Person("Joel", 20, 1.6));
            list.Add(new Person("Joelth", 43, 1.5));
            list.Add(new Person("Joelth", 12, 1.2));
            list.Add(new Person("Joelthes", 1, 1.3));

            double avgHeight = 0;
            foreach (Person p in list) {
                avgHeight += p.getHeight();
            }
            avgHeight /= list.Count;

            IEnumerable<Person> tallQuery =
                from person in list
                where person.getHeight() >= avgHeight
                select person;

            IEnumerable<Person> kidQuery =
                from person in list
                where person.getAge() <= 12
                select person;

            Console.WriteLine("People who are taller than average: ");
            foreach (Person person in tallQuery) {
                Console.WriteLine(person.getName()+": "+person.getHeight());
            }
            Console.WriteLine("People who are at or under 12");
            foreach (Person person in kidQuery)
            {
                Console.WriteLine(person.getName() + ": " + person.getAge());
            }
        }
    }

    public class Person {
        private string name;
        private int age;
        private double height;
        public Person(string name, int age, double height) {this.name = name; this.age = age; this.height = height;}

        public string getName() {return name;}
        public int getAge() {return age;}
        public double getHeight() {return height;}

        public void setName(string name) { this.name = name; }
        public void setAge(int age) {this.age = age;}
        public void setHeight(double height) {this.height = height;}
    }
}
