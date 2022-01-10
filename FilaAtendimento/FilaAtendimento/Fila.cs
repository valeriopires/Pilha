using System;
using System.Collections.Generic;

namespace FilaAtendimento
{
    public class Fila
    {
        private Queue<int> _filaDeAtendimento;
        private int _proximoDaFila = 1;

        public Fila()
        {
            _filaDeAtendimento = new Queue<int>();
        }

        public int GerarSenha()
        {
            _filaDeAtendimento.Enqueue(_proximoDaFila);
            Console.WriteLine("Senha gerada com sucesso!");
            return _proximoDaFila++;
        }

        public void ChamarProximo()
        {
            var proximoNumeroDaFila = _filaDeAtendimento.Dequeue();
            Console.WriteLine($"Próxima senha: {proximoNumeroDaFila}");
        }

        public void MostrarFila()
        {
            Console.Write("Senhas da Fila: ");

            foreach (var senha in _filaDeAtendimento)
            {
                Console.Write(senha + " ");
            }
            Console.WriteLine();
        }

        public void ReiniciarFila()
        {
            _filaDeAtendimento.Clear();
        }

    }
}
