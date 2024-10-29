using System;
public class Guerreiro
{
    public string Nome { get; private set; }
    public virtual int Ataque { get; private set; } 
    public virtual int Defesa { get; private set; } 
    public int Vida { get; private set; }

    public Guerreiro(string nome, int ataque, int defesa, int vida)
    {
        Nome = nome;
        Ataque = ataque;
        Defesa = defesa;
        Vida = vida;
    }

    public virtual void ReceberDano(int dano)
    {
        int danoEfetivo = Math.Max(0, dano - Defesa);
        AtualizarVida(-danoEfetivo); // Atualiza a vida
        Console.WriteLine($"{Nome} recebeu {danoEfetivo} de dano! Vida restante: {Vida}");
    }

    public void AtualizarVida(int delta)
    {
        Vida += delta;
        Vida = Math.Max(Vida, 0); // Garante que a vida não fique negativa
    }

    public virtual void Atacar(Guerreiro alvo)
    {
        Console.WriteLine($"{Nome} ataca {alvo.Nome} com {Ataque} de ataque!");
        alvo.ReceberDano(Ataque);
    }
}

