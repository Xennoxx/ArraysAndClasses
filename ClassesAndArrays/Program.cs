﻿using ClassesAndArrays;

class program
{
    static void Main(string[] args)
    {
            Console.Write("Bitte wählen Sie die Anzahl der Spieler: ");
            int playeranz = Convert.ToInt32(Console.ReadLine());
            Spieler[] sp = new Spieler[playeranz];
            for (int a = 1; a <= playeranz; a++)
            {
                Console.Write("Spieler" + a + " Name: ");
                string input = Console.ReadLine();
                sp[a] = new Spieler(input);
                Console.WriteLine("Danke. Du heißt jetzt " + sp[a].name + ".");
        }
    }
}