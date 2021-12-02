var numbers = File.ReadAllLines("input.txt").ToList();

void PartOne()
{
    int horizontal = 0;
    int depth = 0;

    foreach (var n in numbers)
    {
        var x = n.Split(' ');
        var direction = x[0];
        var amount = Int32.Parse(x[1]);

        if (direction == "forward")
            horizontal += amount;
        else if (direction == "down")
            depth += amount;
        else if (direction == "up")
            depth -= amount;
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
        var direction = x[0];
        var amount = Int32.Parse(x[1]);

        if (direction == "forward")
        {
            horizontal += amount;
            depth += aim * amount;
        }
        else if (direction == "down")
            aim += amount;
        else if (direction == "up")
            aim -= amount;

    }

    Console.WriteLine($"{horizontal} * {depth} = {horizontal * depth}");
}

PartTwo();
