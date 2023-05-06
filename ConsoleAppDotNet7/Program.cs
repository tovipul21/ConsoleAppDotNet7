using RequiredProperties;


#region Required Properties feature
//PersonalModel pm1 = new("Tim", "Jones");

PersonalModel pm2 = new() { FirstName = "Tim" };

// pm1
//Console.WriteLine("This data is from pm1 object - " + pm1.FirstName);

// pm2
Console.WriteLine("This data is from pm2 object - " + pm2.FirstName + " " + pm2.LastName);

Console.WriteLine("===================End of required properties===================");
Console.WriteLine("");
Console.WriteLine("");
#endregion


#region New LINQ Ordering technique
Console.WriteLine("===================Start of Ordering/Sorting techniques===================");
List<int> randomNumbers = new () {12,8, 26, 45, 38, 59, 72, 63, 85, 102,95 };

List<string> randomNames = new () { "Tim", "Keith", "Jeremy", "Katy", "Julie", "Paul", "Michael" };

// Old style of sorting the data
var oldOrderingOfNumber = randomNumbers.OrderBy(x => x);
var oldOrderingOfName = randomNames.OrderBy(x => x);

foreach (var number in oldOrderingOfNumber)
    Console.WriteLine("Old Random Number is " + number);

Console.WriteLine("<------------------------------------------------------------------------>");

foreach (var name in oldOrderingOfName)
    Console.WriteLine("Old Random Name is " + name);

// New style of sorting the data
var newOrderingOfNumber = randomNumbers.Order();
var newOrderingOfName = randomNames.Order();

Console.WriteLine("=======================================================================");

foreach (var number in newOrderingOfNumber)
    Console.WriteLine("Random Number is " + number);

Console.WriteLine("<------------------------------------------------------------------------>");

foreach (var name in newOrderingOfName)
    Console.WriteLine("Random Name is " + name);

Console.WriteLine("<------------------------------------------------------------------------>");

List<PersonalModel> peopleList = new()
{
    new PersonalModel() { FirstName = "Tim", Age = 45 },
    new PersonalModel() { FirstName = "Julie", Age = 21},
    new PersonalModel() { FirstName = "Michael", Age = 33}
};

var peoples = peopleList.OrderByDescending(ppl => ppl.FirstName);

foreach (var item in peoples)
    Console.WriteLine("Order of complex object is - " + item.FirstName);

Console.WriteLine("===================End of Ordering/Sorting techniques===================");
#endregion