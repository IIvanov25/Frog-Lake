using Frog_Lake;

Lake lake = new Lake();
int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

foreach (int number in numbers)
{
    lake.Stones.Add(number);
}

lake.FindOddNumbers();
lake.FindEvenNumbers();


