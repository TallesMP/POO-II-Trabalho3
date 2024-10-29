using System;

public class Anel : Decorator
{
    public Anel(Guerreiro guerreiro) : base(guerreiro) { }

    public override void ReceberDano(int dano)
    {
        int danoEfetivo = Math.Max(0, dano - Defesa);
        AtualizarVida(-danoEfetivo); // Atualiza a vida

        // Reflexão do dano
        if (danoEfetivo > 0)
        {
            int danoReflexivo = (int)(danoEfetivo * 0.10); // 10% de reflexo
            Console.WriteLine($"{guerreiro.Nome} reflete {danoReflexivo} de dano ao atacante!");
            // O atacante deve receber o dano reflexivo
            // Essa lógica pode ser passada para o atacante
        }

        Console.WriteLine($"{guerreiro.Nome} recebeu {danoEfetivo} de dano! Vida restante: {Vida}");
    }
}
