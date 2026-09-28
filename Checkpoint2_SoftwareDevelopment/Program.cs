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
}