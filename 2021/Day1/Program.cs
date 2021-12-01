var numbers = File.ReadAllLines("input.txt").Select(line => Int32.Parse(line)).ToList();

void PartOne()
{
    int previousNumber = 9999;
    int increased = 0;

    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] > previousNumber)
            increased++;

        previousNumber = numbers[i];
    }
    Console.WriteLine("Increased: " + increased);
}

void PartTwo()
{
    int previousSum = 99999;
    int increased = 0;

    for (int i = 0; i < numbers.Count - 2; i++)
    {
        int firstNumber = numbers[i];
        int secondNumber = numbers[i + 1];
        int thirdNumber = numbers[i + 2];
        int sum = firstNumber + secondNumber + thirdNumber;
        if (sum > previousSum)
            increased++;
        previousSum = sum;
    }
    Console.WriteLine("Increased: " + increased);
}

PartTwo();