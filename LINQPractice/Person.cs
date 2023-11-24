namespace LINQPractice
{
    public class Person
    {
        private static int Count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Id = ++Count;
            Name = name;
            Age = age;
        }

        public override string ToString()
            => $"ID: {Id}; Name:{Name}; Age: {Age}";
    }
}
