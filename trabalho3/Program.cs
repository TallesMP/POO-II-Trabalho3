using System;
class Program
{
    static void Main(string[] args)
    {
        Guerreiro guerreiro1 = new Guerreiro("Guerreiro1", 30, 10, 100);
        Guerreiro guerreiro2 = new Guerreiro("Guerreiro2", 25, 5, 80);

        // Equipar e decorar guerreiros
        guerreiro1 = new Anel(guerreiro1); // Agora o anel é um equipamento
        guerreiro1 = new Espada(guerreiro1);
        guerreiro1 = new Armadura(guerreiro1);

        guerreiro2 = new Espada(guerreiro2);
        guerreiro2 = new Armadura(guerreiro2);

        // Simulação de batalha
        int turno = 0;
        while (guerreiro1.Vida > 0 && guerreiro2.Vida > 0)
        {
            Console.WriteLine($"\n--- Turno {++turno} ---");
            
            // Guerreiro 1 ataca Guerreiro 2
            guerreiro1.Atacar(guerreiro2);

            // Verifica se Guerreiro 2 foi derrotado
            if (guerreiro2.Vida <= 0)
            {
                Console.WriteLine($"{guerreiro2.Nome} foi derrotado!");
                break;
            }

            // Guerreiro 2 ataca Guerreiro 1
            guerreiro2.Atacar(guerreiro1);

            // Verifica se Guerreiro 1 foi derrotado
            if (guerreiro1.Vida <= 0)
            {
                Console.WriteLine($"{guerreiro1.Nome} foi derrotado!");
                break;
            }
        }

        // Exibe a vida final dos guerreiros
        Console.WriteLine($"{guerreiro1.Nome} Vida final: {guerreiro1.Vida}");
        Console.WriteLine($"{guerreiro2.Nome} Vida final: {guerreiro2.Vida}");
    }
}
