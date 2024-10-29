
public class Espada : Decorator
{
    public Espada(Guerreiro guerreiro) : base(guerreiro) { }

    public override int Ataque => guerreiro.Ataque + 10; // Incrementa o ataque em 10
}

