// Screen Sound

string mensagem = "Boas Vindas ao Screen Sound!\n";
// List<string> listaDasBandas = new List<string>{"Skank", "Capital Inicial"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Skank", new List<int>{10, 9, 9});
bandasRegistradas.Add("Beatles", new List<int>());

// void Curiosidades()
// {
//     string nome = "Matheus";
//     string sobrenome = "Menezes";

//     Console.WriteLine($"Olá, {nome}");
//     Console.WriteLine("Olá, {1} {0}", nome, sobrenome);
// }

void ExibirLogo()
{
//     Console.WriteLine(@"
// ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
// ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
// ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
// ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
// ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
// ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

// ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
// ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
// ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
// ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
// ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
// ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine("\n𝑺𝒄𝒓𝒆𝒆𝒏 𝑺𝒐𝒖𝒏𝒅 🎵\n");
    Console.WriteLine(mensagem);
}

void ExibirOpcoesDoMenu()

{
    ExibirLogo();

    Console.WriteLine("1.Registrar banda");
    Console.WriteLine("2.Mostrar bandas");
    Console.WriteLine("3.Avaliar banda");
    Console.WriteLine("4.Exibir média de uma banda");
    Console.WriteLine("0.Sair");

    Console.Write("\nDigite sua opção: "); //não pula linha
    string opcaoEscolhida = Console.ReadLine()!; //garante que existirá um valor

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda(); break;
        case 2: ListarBandas(); break;
        case 3: AvaliarBanda(); break;
        case 4: MostrarAvaliacao(); break;
        case 0: Console.WriteLine("Até mais :D"); break;
        default: Console.WriteLine("Opção inválida!"); break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de Banda");
    Console.Write("Digite o nome da banda: ");
    
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());

    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
} 

void ListarBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Bandas Registradas");
    // for(int i = 0; i < listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // }

    foreach(string banda in bandasRegistradas.Keys) Console.WriteLine($"Banda: {banda}");
    
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu inicial...");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda: ");
    string banda = Console.ReadLine()!;

    if(bandasRegistradas.ContainsKey(banda))
    {
        Console.Write($"Informe a nota de avaliação: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[banda].Add(nota);

        Console.WriteLine($"\nA nota {nota} foi registrada para a banda {banda}!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nA banda {banda} não está regitrada!");
        Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MostrarAvaliacao()
{
    Console.Clear();
    ExibirTituloOpcao("Avaliação da Banda");
    Console.Write("Informe o nome da Banda: ");
    string banda = Console.ReadLine()!;

    if(bandasRegistradas.ContainsKey(banda))
    {
        List<int> notasBanda = bandasRegistradas[banda];
        Console.WriteLine($"\nA média da banda é: {notasBanda.Average()}");
        Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {banda} não está regitrada!");
        Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

void ExibirTituloOpcao(string titulo)
{
    int qtdLetras = titulo.Length;
    string enfase = "".PadLeft(qtdLetras, '*'); //como é um caracter usa-se as aspas simples
    Console.WriteLine(enfase);
    Console.WriteLine(titulo);
    Console.WriteLine(enfase);
    Console.WriteLine();
}



ExibirLogo();
ExibirOpcoesDoMenu();
// Curiosidades();