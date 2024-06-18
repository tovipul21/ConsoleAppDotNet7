namespace RandomNumbersUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    //SimpleMethod(random);
            //    Console.WriteLine(random.NextDouble() * 10);
            //}
            
            List<PersonModel> peopleList = new List<PersonModel>()
            {
                new PersonModel(){ FirstName = "Vipul"},
                new PersonModel(){ FirstName = "Jharna"},
                new PersonModel(){ FirstName = "Kanishk"},
                new PersonModel(){ FirstName = "Diyaan"},
                new PersonModel(){ FirstName = "Purvika"},
                new PersonModel(){ FirstName = "Jignesh"},
                new PersonModel(){ FirstName = "Kajal"},
                new PersonModel(){ FirstName = "Vritika"}
            };

            var sortedPeople = peopleList.OrderBy(x => x.FirstName);

            //IEnumerable<PersonModel> personModels = peopleList;
            //var sortedNames1 = peopleList.OrderBy(x => x.FirstName);

            foreach (PersonModel people in sortedPeople)
            {
                Console.WriteLine(people.FirstName);
            }

            //var strCharRead = Console.ReadLine();
            //Console.WriteLine(strCharRead);


        }

        static void SimpleMethod(Random random)
        {
            Console.WriteLine(random.Next());
        }
    }

    class PersonModel
    {
        public string? FirstName { get; set; }
    }
}
