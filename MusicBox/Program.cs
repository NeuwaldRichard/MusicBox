// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string mensagemDeBoasVinda = "Seja Bem Vindo";

void ExibirBoasVindas()
{
    Console.WriteLine(@"
███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░  ██████╗░░█████╗░██╗░░██╗
████╗░████║██║░░░██║██╔════╝██║██╔══██╗  ██╔══██╗██╔══██╗╚██╗██╔╝
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝  ██████╦╝██║░░██║░╚███╔╝░
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗  ██╔══██╗██║░░██║░██╔██╗░
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝  ██████╦╝╚█████╔╝██╔╝╚██╗
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░  ╚═════╝░░╚════╝░╚═╝░░╚═╝
");
    Console.WriteLine(mensagemDeBoasVinda);   
}
ExibirBoasVindas();

void ExibirMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite 0 para sair.");
}
ExibirMenu();

Console.Write("\nDigite Sua Opção: ");
string opcaoEscolhida = Console.ReadLine();
int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
if (opcaoEscolhidaNumerica == 1)
{

    Console.WriteLine( "Você digitou a opção " + opcaoEscolhida );
}
