
namespace FilaAtendimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();

            fila.GerarSenha();
            fila.GerarSenha();
            fila.GerarSenha();

            fila.ChamarProximo();

            fila.MostrarFila();

            fila.ReiniciarFila();

            fila.MostrarFila();
        }
    }
}
