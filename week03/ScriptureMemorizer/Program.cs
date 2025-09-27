using System;

class Program
{
    static void Main()
    {
        // Crear referencia y escritura
        Reference reference = new Reference("Juan", 3, 16);
        Scripture scripture = new Scripture(reference, "Porque de tal manera amó Dios al mundo, que ha dado a su Hijo unigénito");

        // Número de palabras a ocultar por vez
        int wordsToHide = 2;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.IsCompletelyHidden())
                break;

            Console.WriteLine("\nPresiona Enter para ocultar algunas palabras o escribe 'quit' para salir:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(wordsToHide);
        }

        Console.WriteLine("\nTodas las palabras están ocultas. Fin del programa.");
    }
}
