class Program
{
    // Método para apresentar o menu
    static void Menu()
    {
        Console.WriteLine("\n") ;
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

    static void Main()
    {
        Console.WriteLine("Bem-vindo a calculadora de notas v30");

        HashSet<int> notas = new HashSet<int>();

        while (true)
        {
            Menu();
            string escolha = Console.ReadLine();

            if (!int.TryParse(escolha, out int e))
            {
                Console.WriteLine("Falha na conversão, digite um valor válido!");
                continue;
            }

            Console.WriteLine("Valor recebido com sucesso!");

            if (e < 1 || e > 4)
            {
                Console.WriteLine("Digite o respectivo valor apresentado no menu!");
                continue;
            }

            if (e == 1)
            {
                CadastrarAluno();
            }

            if (e == 2)
            {
                notas = LancarNotas();
            }

            if (e == 3)
            {
                double media = CalcularMedia(notas);

                Console.WriteLine($"Média do Aluno: {media:F2}");

                ExibirSituacao(media);
            }

            if (e == 4)
            {
                break;
            }
        }
    }
}