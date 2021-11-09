public class Gerente:Funcionario
{
    public int NumeroAgencias {get;set;}

    public override double Bonificacao
    {
        get
        {
            return bonificacao;
        }
        set
        {
            bonificacao += value*0.05;
        }
    }

    public override int CalcularFerias()
    {
        int diasFerias = 30+NumeroAgencias*5;
        return diasFerias;
    }
}