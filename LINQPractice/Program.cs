namespace LINQPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intsList = new List<int>();
            List<Person> people = new List<Person>();

            CreatingListOfInts(intsList);
            CreatingListOfPersons(people);

            //***Testing operations with List<int>***
            foreach (var item in GetOddNumbers(intsList))
            {
                Console.WriteLine(item);
            }

            foreach (var item in GetAllElementsInSecondDegree(intsList))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Sum of all elements: {SumOfAllElements(intsList)}");

            //***Testing operations with List<Person>***
            foreach (var item in GetPeopleOnlyOlderThen20(people))
            {
                Console.WriteLine(item);
            }

            ShowPeopleOlderThen20WithSort(people);

            //***Testing extention method***
            Console.WriteLine($"Penultimate int: {intsList.GetPenultimateElement()}");
            Console.WriteLine($"Penultimate people: {people.GetPenultimateElement()}");
        }

        #region Operations with List<int>
        /// <summary>
        /// Clearing collection and adding ints from 1 to 100 to list of ints
        /// </summary>
        /// <param name="list">List to clear and add elements</param>
        static void CreatingListOfInts(List<int> list)
        {
            list.Clear();

            for (int i = 1; i <= 100; i++)
                list.Add(i);
        }

        /// <summary>
        /// Gets the odd numbers from list of ints 
        /// </summary>
        /// <param name="list">List of ints</param>
        /// <returns>New list of ints that contains only odd elements from argument</returns>
        static List<int> GetOddNumbers(List<int> list)
            => list.Where(x => x % 2 != 0).ToList();

        /// <summary>
        /// Gets the elements in second degree from list of ints 
        /// </summary>
        /// <param name="list">List of ints</param>
        /// <returns>New list of ints with elements in second degree from argument</returns>
        static List<int> GetAllElementsInSecondDegree(List<int> list)
            => list.Select(x => x * x).ToList();

        /// <summary>
        /// Gets sum of all elements from list of ints
        /// </summary>
        /// <param name="list">List of ints</param>
        /// <returns>Sum of all elements of argument</returns>
        static int SumOfAllElements(List<int> list)
            => list.Sum(x => x);

        #endregion

        #region Operations with List<Person>
        /// <summary>
        /// Clearing collection and adding 20 Persons to list
        /// </summary>
        /// <param name="people">List to clear and add elements</param>
        static void CreatingListOfPersons(List<Person> people)
        {
            people.Clear();
            List<string> names = new List<string>()
            {
                "Ivan",
                "Alex",
                "Roman",
                "Jeka",
                "Alim",
                "Julia",
                "Sofia",
                "Milena",
                "Vadym",
                "Olha",
                "Petro",
                "Ilya",
                "Liza",
                "Dasha",
                "Masha",
                "David",
                "Den",
                "Lina",
                "Max",
                "Dmytro",
            };

            foreach (var item in names)
                people.Add(new Person(item, new Random().Next(1, 70)));
        }

        /// <summary>
        /// Gets Persons only older then 20 inclusive
        /// </summary>
        /// <param name="list">List of persons</param>
        /// <returns>Returns new List<Person> that contains only persons older then 20 inclusive</returns>
        static List<Person> GetPeopleOnlyOlderThen20(List<Person> list)
            => list.Where(x => x.Age >= 20).ToList();

        /// <summary>
        /// Sorted shows people older then 20 inclusive 
        /// </summary>
        /// <param name="list">List of persons</param>
        static void ShowPeopleOlderThen20WithSort(List<Person> list)
        {
            var sortedPeople = GetPeopleOnlyOlderThen20(list)
                .OrderBy(x => x.Name)
                .Select(x => new { Name = x.Name, Id = x.Id});

            foreach (var person in sortedPeople)
                Console.WriteLine($"Id: {person.Id} Name: {person.Name}");
        }

        #endregion
    }
}