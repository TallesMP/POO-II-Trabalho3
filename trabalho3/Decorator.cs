public abstract class Decorator : Guerreiro
{
    protected Guerreiro guerreiro;

    protected Decorator(Guerreiro guerreiro) : base(guerreiro.Nome, guerreiro.Ataque, guerreiro.Defesa, guerreiro.Vida)
    {
        this.guerreiro = guerreiro;
    }

    public override void ReceberDano(int dano)
    {
        guerreiro.ReceberDano(dano);
        AtualizarVida(guerreiro.Vida - Vida); // Atualiza a vida corretamente
    }

    public override void Atacar(Guerreiro alvo)
    {
        guerreiro.Atacar(alvo);
    }
}
