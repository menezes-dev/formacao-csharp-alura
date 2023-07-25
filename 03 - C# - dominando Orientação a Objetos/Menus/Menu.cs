namespace ScreenSound.Menus;
using ScreenSound.Modelos;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas) //o virtual informa que o método pode ser sobrescrito nos filhos
    {
        Console.Clear();
    }
}