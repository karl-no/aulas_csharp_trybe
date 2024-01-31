namespace namespaceExample;

//Criando um enum
enum CardinalPoints
{
    Norte,
    Sul,
    Leste,
    Oeste
};

class Program
{
    public static void Main()
    {
        //Utilizando um enum
        CardinalPoints direction = CardinalPoints.Norte;
        Console.WriteLine("Ponto Cardeal: " + direction);
    }
}

