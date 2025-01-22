using ORMs;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

int sum = 0;
foreach (int n in numbers)
{
    sum += n;
}

Console.WriteLine($"{numbers.Sum()}");
Console.WriteLine($"{numbers.Average()}");

// var evenNumbers = from number in numbers where number % 2 == 0 select number;

//Evaluation of these statements does not happen here
var evenNumbers = numbers.Where(n => n % 2 == 0);
var oddNumbersSquaredSum = numbers.Where(n => n % 2 == 1).Select(n => n * n).Sum();
var numbersHigherThanOrEqualTo5 = numbers.Where(n => n >= 5);
var squares = numbers.Select(n => n * n).ToList();

numbers.Add(11);
numbers.Add(17);
numbers.Add(16);
numbers.Add(14);

//It is evaluated when it is used
Console.WriteLine("EVEN");
foreach (int n in evenNumbers)
{
    Console.WriteLine(n);
}
Console.WriteLine("SQUARED");
foreach (int n in squares)
{
    Console.WriteLine(n);
}
Console.WriteLine($"ODD_SQUARED_SUM = {oddNumbersSquaredSum}");

List<Product> products = new List<Product>();
for (int i = 0; i < 10; i++)
{
    Product product = new Product()
    {
        Id = i + 1,
        Name = $"Product {i + 1}",
        Price = 1000.50 + i,
        Quantity = 1 + i,
    };
    products.Add(product);
}

foreach (Product p in products)
{
    Console.WriteLine($"{p.Name}");
}

var value = products.Sum(p => p.Price);
Console.WriteLine($"Total Price {value}");
var item = products.FirstOrDefault(p => p.Id == 3);
Console.WriteLine($"Item with ID = 3 is {item.Name}");
var items = products.Where(p => p.Price > 1005.5);
foreach (var i in items)
{
    Console.WriteLine(i.Name);
}
