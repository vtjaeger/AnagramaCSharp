using AnagramaP2.Class;
using System.Reflection.Metadata.Ecma335;

while (true)
{
    Console.WriteLine("BEM VINDO\n");
    Console.WriteLine("Escreva uma palavra:");

    string palavra = Console.ReadLine()!;
    Console.WriteLine($"\nÉ possível escrever {palavra} de {Anagram.CalculaAnagrama(palavra)} formas diferentes.");
    Thread.Sleep(2000);

    Console.WriteLine("\nPara continuar aperte 1.\nCaso queira sair aperte qualquer outra tecla.");
    string opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case "1":
            Console.Clear();
            break;
        default:
            Thread.Sleep(150);
            Console.Write($"Saindo");
            Thread.Sleep(150);
            Console.Write(" do");
            Thread.Sleep(150);
            Console.Write(" programa...");
            Thread.Sleep(400);
            return;
    }
}


