using RequiredProperties;

//PersonalModel pm1 = new("Tim", "Jones");

PersonalModel pm2 = new() { FirstName = "Tim"};

// pm1
//Console.WriteLine("This data is from pm1 object - " + pm1.FirstName);

// pm2
Console.WriteLine("This data is from pm2 object - " + pm2.FirstName + " " + pm2.LastName);

