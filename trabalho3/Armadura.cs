using System;

 
public class Armadura : Decorator
{
    public Armadura(Guerreiro guerreiro) : base(guerreiro) { }

    public override int Defesa => guerreiro.Defesa + 10; // Incrementa a defesa em 10
}

