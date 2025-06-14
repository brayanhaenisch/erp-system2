public static class Program
{
    public static void Main(string[] args)
    {
        MenuPrincipal();
    }
    public static void MenuPrincipal()
    {
        Console.WriteLine("Bem vindo ao Brayan-ERP!");
        Console.WriteLine("Qual módulo você quer acessar?");
        Console.WriteLine("1 - Cadastros\n2 - Movimentação\n");
        var modulo = Console.ReadLine();
        if (modulo == "1")
        {
            Cadastro.Menu.MenuCadastro();
            MenuPrincipal();
        }

        else if (modulo == "2")
            Console.WriteLine("\nEsta tela ainda não está disponível.\n");
        else
            Console.WriteLine("Opção inválida");
    }
}