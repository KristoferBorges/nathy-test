class Desafio_58
{
    public static void AdivinheMelhorado()
    {
        while (true)
        {
            Random random = new Random();
            int choiceComputer = random.Next(1, 10 + 1);

            Console.Write("\n\n[COMPUTADOR] - Adivinhe o n�mero que estou pensando...\n --> ");
            int choicePlayer = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"SUA ESCOLHA FOI O N�MERO [{choicePlayer}]");
            Console.WriteLine($"EU PENSEI NO N�MERO [{choiceComputer}]");

            if (choicePlayer == choiceComputer)
            {
                Console.Write("[ ! ] - VOC� VENCEU.");
                break;
            }
            else 
            {
                Console.Write("[ ! ] - VOC� PERDEU HAHA.");
                continue;
            }
        }
    }
}
