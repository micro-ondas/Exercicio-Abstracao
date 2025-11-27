using System;

class Pessoa : Acao
{
    public override void Andar()
    {
        Console.WriteLine("vtmnc me deixa andar");
    }

    public override void Falar()
    {
        Console.WriteLine("to falano garela");
    }
}