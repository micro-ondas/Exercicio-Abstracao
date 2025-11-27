using System;

abstract class Acao
{

    public abstract void Falar();

    public abstract void Andar();

    public void Pular()
    {
        Console.WriteLine("to pulano garela");
    }

}