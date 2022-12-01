var calorieData = File.ReadAllText("input.txt").Trim()
    .Split("\n\n", StringSplitOptions.RemoveEmptyEntries)
    .Select(x => x.Split("\n"))
    .Select(x => x.Sum(n => int.Parse(n)))
    .OrderByDescending(x => x);
Console.WriteLine(calorieData.First());
Console.WriteLine(calorieData.Take(3).Sum());

