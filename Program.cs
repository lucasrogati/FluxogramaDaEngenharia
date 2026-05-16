Console.WriteLine("--- Fluxograma da Engenharia ---");
Console.WriteLine("O objeto está se movendo (S/N)?");

string movendo = Console.ReadLine()!;

if (movendo == "S")
{
    Console.WriteLine("Deveria (S/N)?");

    string deveriamover = Console.ReadLine()!;

    if (deveriamover == "S")
    {
        Console.WriteLine("Ótimo");
    }
    else if (deveriamover == "N")
    {
        Console.WriteLine("Use silver tape!");
    }
}
else if (movendo == "N")
{
    Console.WriteLine("Deveria (S/N)?");

    string deveria = Console.ReadLine()!;

    if (deveria == "S")
    {
        Console.WriteLine("Use WD-40");
    }
    else if (deveria == "N")
    {
        Console.WriteLine("Ótimo");
    }
}