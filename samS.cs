using System;

class Aluno
{
    public string RA { get; set; }
    public string Nome { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public double NotaFinal { get; private set; }

    public void CalcularMedia()
    {
        NotaFinal = (NotaProva + NotaTrabalho) / 2;
    }

    public bool CalcularNotaFinal(out double notaProvaFinal)
    {
        double notaNecessaria = 5 - NotaFinal * 0.6;
        notaProvaFinal = notaNecessaria / 0.4;
        return NotaFinal >= 5;
    }

    public void ImprimirNotaFinal()
    {
        Console.WriteLine($"Nota Final: {NotaFinal}");
    }

    public void ReceberDados()
    {
        Console.Write("RA: ");
        RA = Console.ReadLine();

        Console.Write("Nome: ");
        Nome = Console.ReadLine();

        Console.Write("Nota da Prova: ");
        NotaProva = double.Parse(Console.ReadLine());

        Console.Write("Nota do Trabalho: ");
        NotaTrabalho = double.Parse(Console.ReadLine());
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();
        aluno.ReceberDados();
        aluno.CalcularMedia();

        if (!aluno.CalcularNotaFinal(out double notaProvaFinal))
        {
            Console.WriteLine($"Nota necessária na prova final: {notaProvaFinal}");
        }

        aluno.ImprimirNotaFinal();
    }
}