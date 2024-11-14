namespace Inicio.Condicional;

public class Condicional
{
    private string nome;
    private int idade;

    public Condicional(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void Verificaidade()
    {
        if (idade >= 18)
        {
            Console.WriteLine($"Olá {nome} você é meior de idade");
        }
        else
        {
            Console.WriteLine($"Olá {nome} você é menor de idade");
        }
    }
}