class Program
{
    // Método para apresentar o menu
    static void Menu()
    {
        Console.WriteLine("""
            Digite o respectivo valor para navegar no sistema:
            1. Cadastrar aluno
            2. Lançar notas
            3. Calcular média
            4. Sair
            """);
    }

    // Método para cadastrar aluno
    static void CadastrarAluno()
    {
        Console.WriteLine("Você escolheu a opção 1 - Cadastrar aluno");
        Console.WriteLine("(caso deseje voltar ao menu, digite 'sair')");
        Console.Write("Informe o nome do aluno: ");

        string nome = Console.ReadLine();
    }

    // Método para lançar notas
    static HashSet<int> LancarNotas()
    {
        HashSet<int> notas = new HashSet<int>();

        Console.WriteLine("Você escolheu a opção 2 - Lançar notas");
        Console.WriteLine("Informe as 3 notas do respectivo aluno");

        Console.Write("Primeira nota: ");
        string nota1 = Console.ReadLine();

        Console.Write("Segunda nota: ");
        string nota2 = Console.ReadLine();

        Console.Write("Terceira nota: ");
        string nota3 = Console.ReadLine();

        if (int.TryParse(nota1, out int n1))
        {
            Console.WriteLine("Valor recebido com sucesso!");
            notas.Add(n1);
        }
        else
        {
            Console.WriteLine("Falha na conversão, digite um valor válido!");
        }

        if (int.TryParse(nota2, out int n2))
        {
            Console.WriteLine("Valor recebido com sucesso!");
            notas.Add(n2);
        }
        else
        {
            Console.WriteLine("Falha na conversão, digite um valor válido!");
        }

        if (int.TryParse(nota3, out int n3))
        {
            Console.WriteLine("Valor recebido com sucesso!");
            notas.Add(n3);
        }
        else
        {
            Console.WriteLine("Falha na conversão, digite um valor válido!");
        }

        return notas;
    }

    // Método calcular média
    static double CalcularMedia(HashSet<int> notas)
    {
        Console.WriteLine("Você escolheu a opção 3 - Calcular média");

        int soma = 0;

        foreach (int nota in notas)
        {
            soma += nota;
        }

        return (double)soma / notas.Count;
    }

    // Método exibir situação
    static void ExibirSituacao(double media)
    {
        const double MEDIA_APROVACAO = 7.0;
        const double MEDIA_RECUPERACAO = 5.0;

        if (media >= MEDIA_APROVACAO)
        {
            Console.WriteLine("Aprovado!");
        }
        else if (media >= MEDIA_RECUPERACAO)
        {
            Console.WriteLine("Recuperação!");
        }
        else
        {
            Console.WriteLine("Reprovado!");
        }
    }
}