Console.WriteLine("--- Fluxograma da Engenharia ---");

Console.Write("O objeto está se movendo (S/N)? ");
string movendo = Console.ReadLine()!.ToUpper().Substring(0,1);

if (movendo == "S")
{
    Console.Write("Deveria estar se movendo (S/N)? ");
    string deveriaMover = Console.ReadLine()!.ToUpper().Substring(0,1);;

    if (deveriaMover == "S")
    {
        Console.WriteLine("Ótimo!");
    }
    else if (deveriaMover == "N")
    {
        Console.WriteLine("Use silver tape!");
    }
    else
    {
        Console.WriteLine("Resposta inválida.");
    }
}
else if (movendo == "N")
{
    Console.Write("Deveria estar se movendo (S/N)? ");
    string deveriaMover = Console.ReadLine()!.ToUpper().Substring(0,1);;

    if (deveriaMover == "S")
    {
        Console.WriteLine("Use WD-40!");
    }
    else if (deveriaMover == "N")
    {
        Console.WriteLine("Ótimo!");
    }
    else
    {
        Console.WriteLine("Resposta inválida.");
    }
}
else
{
    Console.WriteLine("Resposta inválida.");
}