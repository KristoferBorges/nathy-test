class Desafio_58
{
    public static void AdivinheMelhorado()
    {   
        Random random = new Random();
        int choiceComputer = random.Next(1, 10 + 1);
        int tentativas = 1;

        Console.Write("\n[COMPUTADOR] - Adivinhe o n�mero que estou pensando...\n --> ");
        int choicePlayer = int.Parse(Console.ReadLine().Trim());

        while (choiceComputer != choicePlayer)
        {
            if (choicePlayer < choiceComputer)
            {
                Console.Write("[MAIS] - TENTE NOVAMENTE...");
            }
            else if (choicePlayer > choiceComputer)
            {
                Console.Write("[MENOS] - TENTE NOVAMENTE...");
            }

            Console.Write("\n[COMPUTADOR] - Adivinhe o n�mero que estou pensando...\n --> ");
            choicePlayer = int.Parse(Console.ReadLine().Trim());
            tentativas++;
        }
        Console.WriteLine("\n[ ! ] - VOC� VENCEU!");
        Console.WriteLine($"SUA ESCOLHA FOI O N�MERO [{choicePlayer}]");
        Console.WriteLine($"EU PENSEI NO N�MERO [{choiceComputer}]");
        Console.WriteLine($"[{tentativas}]");
    }
}
