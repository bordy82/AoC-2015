using Utilities;

SolvePuzzleOne();
SolvePuzzleTwo();

void SolvePuzzleOne()
{
    var cpt = 0;
    var myValue = DataLoader.GetStringDataFromFile().First();

    foreach (var c in myValue)
    {
        if (c == ')')
            cpt--;
        else
            cpt++;
    }

    Console.WriteLine($"Réponse 1 : {cpt}");
}

void SolvePuzzleTwo()
{
    var cpt = 0;
    var index = 0;
    var myValue = DataLoader.GetStringDataFromFile().First();

    foreach (var c in myValue)
    {
        index++;

        if (c == ')')
            cpt--;
        else
            cpt++;

        if (cpt < 0)
            break;
    }

    Console.WriteLine($"Réponse 2 : {index}");
}