var numbers = File.ReadAllLines("input.txt").ToList();

void PartOne()
{
    int horizontal = 0;
    int depth = 0;

    foreach (var n in numbers)
    {
        var x = n.Split(' ');
        if (x[0] == "forward")
        {
            horizontal += Int32.Parse(x[1]);
        }
        else if (x[0] == "down")
        {
            depth += Int32.Parse(x[1]);
        }
        else if (x[0] == "up")
        {
            depth -= Int32.Parse(x[1]);
        }
    }

    Console.WriteLine($"{horizontal} * {depth} = {horizontal * depth}");
}

void PartTwo()
{
    int horizontal = 0;
    int depth = 0;
    int aim = 0;

    foreach (var n in numbers)
    {
        var x = n.Split(' ');
        if (x[0] == "forward")
        {
            horizontal += Int32.Parse(x[1]);
            depth += aim * Int32.Parse(x[1]);
        }
        else if (x[0] == "down")
        {
            aim += Int32.Parse(x[1]);
        }
        else if (x[0] == "up")
        {
            aim -= Int32.Parse(x[1]);
        }
    }

    Console.WriteLine($"{horizontal} * {depth} = {horizontal * depth}");
}

PartTwo();
