namespace ScreenSound.Menus;
using ScreenSound.Modelos;
internal class MenuAvaliarBanda : Menu //Herança, MenuAvaliarBanda Herda as características de Menu 
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas) //o override é para usar o que tem no ancestral, mas podendo sobrescrever
    {
        base.Executar(bandasRegistradas); //Para executar a base dos métodos que tá no ancestral
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}