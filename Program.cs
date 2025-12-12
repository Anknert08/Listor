
List<double> numbers = new List<double>{3.2,3.7,4.1,2.6,6.2};
numbers.RemoveAt(3);

foreach (double number in numbers)
{
    Console.WriteLine(number);
}
average();


double average()
{
    double sum = 0;
    foreach (double number in numbers)
    {
        sum = sum += number;
    }
    
    return sum / numbers.Count;
}
