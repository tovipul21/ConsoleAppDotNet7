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
List<int> randomNumbers = new() { 12, 8, 26, 45, 38, 59, 72, 63, 85, 102, 95 };

List<string> randomNames = new() { "Tim", "Keith", "Jeremy", "Katy", "Julie", "Paul", "Michael" };

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

Console.WriteLine("<------------------------------------------------------------------------>");

#endregion

#region "Play with string"

Console.WriteLine("====================Start of reverse a string===========================");
string stringToBeReversed = "This string is to be reversed";

string reversedString = null;
char[] charArray = null;
//strThatisReversed = strToBeReversed.Reverse() .ToString();
charArray = stringToBeReversed.ToCharArray();
Array.Reverse(charArray);
reversedString = new string(charArray);

//char[] charArray = strToBeReversed.ToCharArray();
//Array.Reverse(charArray);
//string strThatisReversed = new string(charArray);

Console.WriteLine("Reverse string is as follows - " + reversedString);

Console.WriteLine("====================End of reverse a string===========================");
#endregion

#region "Learn Generic"

Storage<int> storage = new Storage<int>();
storage.SetValue(2);
Console.WriteLine("Stored Integer - " + storage.GetValue());

Storage<string> storage1 = new Storage<string>();
storage1.SetValue("Some string here");
Console.WriteLine("Stored String - " + storage1.GetValue());

public class Storage<T>
{
    private T _value;

    public void SetValue(T value)
    { this._value = value; }

    public T GetValue() { return this._value; }
}

#endregion