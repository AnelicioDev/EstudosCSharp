using System.Globalization;
namespace Inicio.Src;

public class ExSaidaDados
{
    private double saldo = 2.225;
    private string nome;

    public ExSaidaDados(string nome)
    {
        this.nome = nome;
    }

    public void MostraDados()
    {
        Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine($"{nome} seu saldo {saldo}");
    }
}