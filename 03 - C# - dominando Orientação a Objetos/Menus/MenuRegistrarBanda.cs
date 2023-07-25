namespace ScreenSound.Menus;
using ScreenSound.Modelos;
using OpenAI_API;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        // var client = new OpenAIAPI("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");
        // var chat = client.Chat.CreateConversation();
        // chat.AppendSystemMessage($"Crie uma descrição da banda {nomeDaBanda} com 1 parágrafo, Use uma linguagem informal.");
        // string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        // banda.Resumo = resposta;

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}