namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto) // não usa nada externo, pode chamar o método direto pelo tipo, sem instanciar com new
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}